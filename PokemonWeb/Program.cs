using PokemonWeb;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using System.Web;
using Microsoft.Extensions.Caching.Distributed;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddStackExchangeRedisCache(options => {
    options.Configuration = builder.Configuration["RedisAddress"];
    options.InstanceName = "local";
});
var app = builder.Build();

Config.EmailAddress = builder.Configuration["EmailAddress"];
Config.EmailPasswd = builder.Configuration["EmailPassword"];
Config.FtpAddress = builder.Configuration["FtpAddress"];
Config.FtpUsername = builder.Configuration["FtpUsername"];
Config.FtpPassword = builder.Configuration["FtpPassword"];
var pokemonApi = new PokemonApi(app!.Services.GetService<IDistributedCache>()!);
Fight fight = new();
FightsLog log = new();

// app.MapGet("/", (context) => context.Response.Redirect("/api/pokemon"));

app.Run(async (context) =>
{
    var response = context.Response;
    var request = context.Request;
    var path = request.Path;
    var query = request.Query;
    Regex reGetPokemon = new Regex(@"^/pokemon/\d+");
    Regex reGetAbility = new Regex(@"^/ability/\d+");
    Regex reMainPage = new Regex(@"^/page/\d+");
    Regex rePokemonList = new Regex(@"^/pokemon/list");
    Regex reFight = new Regex(@"^/fight\?\S+");
    Regex reFightStep = new Regex(@"^/fight/\d+");
    Regex reDebugFight = new Regex(@"^/debug/fight");
    Regex reFastFight = new Regex(@"^/fight/fast");
    Regex reFtpSendMarkdown = new Regex(@"^/ftp/\d+");
    Regex reSendEmail = new Regex(@"^/send");
    Regex reDebugSendEmail = new Regex(@"^/debugsend");

    try
    {
        int pageAmount = await pokemonApi.GetNumberOfPages();

        if (path == "/api/data" && request.Method == "GET")
        {
            int amount = await pokemonApi.GetPokemonsAmount();
            await context.Response.WriteAsync($"{amount} pokemons, {pageAmount} page(s)");
        }
        else if (path == "/") // NOTE: temporary
        {
            response.Redirect("/api/data");
        }
        else if (path == "/pokemon/random" && request.Method == "GET")
        {
            await response.WriteAsJsonAsync(await pokemonApi.GetRandomPokemonAsync());
        }
        else if (reMainPage.IsMatch(path) && request.Method == "GET")
        {
            int page;
            bool isValidPage = int.TryParse(path.Value!.Split('/')[2], out page);
            if (isValidPage && page >= 1 && page <= pageAmount)
            {
                string json = await pokemonApi.GetPokemons(page);
                response.ContentType = "application/json";
                await response.WriteAsync(json);
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("Invalid path");
            }
        }
        else if (reGetAbility.IsMatch(path) && request.Method == "GET")
        {
            int id;
            bool isValidId = int.TryParse(path.Value!.Split('/')[2], out id);
            if (isValidId)
            {
                try
                {
                    var ability = await pokemonApi.GetAbilityAsync($"ability/{id}");
                    await response.WriteAsJsonAsync(ability);
                }
                catch (Exception exc)
                {
                    await response.WriteAsync("ЪЕЪ: " + exc.Message);
                }
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("Invalid id");
            }
        }
        else if (reGetPokemon.IsMatch(path) && request.Method == "GET")
        {
            int id;
            bool isValidId = int.TryParse(path.Value!.Split('/')[2], out id);
            if (isValidId)
            {
                try
                {
                    var pokemon = await pokemonApi.GetPokemonAsync($"pokemon/{id}");
                    await response.WriteAsJsonAsync(pokemon);
                }
                catch (Exception exc)
                {
                    await response.WriteAsync("ЪЕЪ: " + exc.Message);
                }
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("Invalid id");
            }
        }
        else if (rePokemonList.IsMatch(path) && request.Method == "GET") // /pokemon/list?name=charmander?page=1
        {
            string? filter = query["name"];
            int page = 1;
            bool isValidPage = int.TryParse(query["page"], out page);
            if (isValidPage && page >= 1 && page <= pageAmount)
            {
                (int count, List<Pokemon> pokemons) = await pokemonApi.GetFilteredPokemonListAsync(filter!, page);
                await response.WriteAsJsonAsync(new
                {
                    count = count,
                    results = pokemons
                });
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("Invalid path");
            }
        }
        else if (reFight.IsMatch(path + request.QueryString) && request.Method == "GET")
        {
            int player;
            bool isValidIds = int.TryParse(query["player"], out player);
            if (isValidIds)
            {
                var pokemonPlayer = await pokemonApi.GetPokemonAsync($"pokemon/{player}");
                var pokemonCpu = await pokemonApi.GetRandomPokemonAsync();
                
                var fightInfo = new List<Pokemon>{pokemonPlayer, pokemonCpu};
                fight = new Fight(pokemonPlayer, pokemonCpu);

                await response.WriteAsJsonAsync(fightInfo);
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("No Pokemon player's ID in \"player\" query.");
            }
        }
        else if (reFightStep.IsMatch(path) && request.Method == "POST")
        {
            int playerNum;
            // bool isValidId = int.TryParse(path.Value!.Split('/')[2], out playerNum);
            using StreamReader reader = new StreamReader(request.Body);
            bool isValidId = int.TryParse(await reader.ReadToEndAsync(), out playerNum);
            Random rnd = new Random();
            if (isValidId)
            {
                if (fight.Rounds != -1)
                {
                    (bool fightResult, bool isPlayerOrder) = fight.Step(playerNum, rnd.Next(1, 10));
                    await response.WriteAsJsonAsync(new
                    {
                        isPlayerMove = isPlayerOrder,
                        rounds = fight.Rounds,
                        playerHp = fight.PokemonPlayerHp,
                        cpuHp = fight.PokemonCpuHp
                    });
                    if (!fightResult)
                        fight.Rounds = -1;
                }
                else
                {
                    response.StatusCode = 405;
                    await response.WriteAsync("Fight isn't initialized.");
                }
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("Invalid id");
            }
        }
        else if (reDebugFight.IsMatch(path))
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(query["num"]!);
                using var resp = await client.PostAsync($"http://localhost:7080/fight/{content}", content);
            }
        }
        else if (reFastFight.IsMatch(path) && request.Method == "GET")
        {
            int player;
            bool isValidIds = int.TryParse(query["player"], out player);
            if (isValidIds)
            {
                var pokemonPlayer = await pokemonApi.GetPokemonAsync($"pokemon/{player}");
                var pokemonCpu = await pokemonApi.GetRandomPokemonAsync();
                
                fight = new Fight(pokemonPlayer, pokemonCpu);
                log = await fight.Fast();
                await response.WriteAsJsonAsync(log);
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("No Pokemon player's ID in \"player\" query.");
            }
        }
        else if (reSendEmail.IsMatch(path) && request.Method == "GET")
        {
            await fight.SendFightEmailAsync(log, query["email"]!);
        }
        else if (reDebugSendEmail.IsMatch(path) && request.Method == "GET")
        {
            await pokemonApi.SendEmailAsync(query["email"]!, query["msg"]!);
            await response.WriteAsync($"E-mail \"{query["msg"]}\" sent on \"{query["email"]}\"");
        }
        else if (reFtpSendMarkdown.IsMatch(path) && request.Method == "GET")
        {
            int id;
            bool isValidId = int.TryParse(path.Value!.Split('/')[2], out id);
            if (isValidId)
            {
                try
                {
                    var pokemon = await pokemonApi.GetPokemonAsync($"pokemon/{id}");
                    await pokemonApi.SaveDataToFtp(pokemon);
                    await response.WriteAsync($"Pokemon \"{pokemon.Name}\"'s data sent to FTP.");
                }
                catch (Exception exc)
                {
                    await response.WriteAsync("ЪЕЪ: " + exc.Message);
                }
            }
            else
            {
                response.StatusCode = 404;
                await response.WriteAsync("Invalid id");
            }
        }
    }
    catch (Exception exc)
    {
        if (exc is HttpRequestException)
        {
            response.StatusCode = 404;
            await response.WriteAsync("PokeAPI isn't available.");
        }
    }
}
);

app.Run();
