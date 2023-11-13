using FluentFTP;
using System.Diagnostics;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace PokemonWeb
{
    public class PokemonApi
    {
        int pageSize;
        HttpClient httpClient;

        public PokemonApi()
        {
            pageSize = 10;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
        }

        public async Task<string> GetPokemons(int pageNumber)
        {
            return await httpClient.GetStringAsync($"pokemon/?limit={pageSize}&offset={(pageNumber - 1) * pageSize}");
        }

        public async Task<int> GetPokemonsAmount()
        {
            int amount;
            var node = JsonNode.Parse(await httpClient.GetStringAsync("pokemon"));
            amount = int.Parse(node!["count"]!.ToString());
            return amount;
        }

        public async Task<int> GetNumberOfPages()
        {
            return await GetPokemonsAmount() / pageSize + 1;
        }

        public async Task<Ability> GetAbilityAsync(string url)
        {
            var result = await httpClient.GetAsync(url);
            if (result.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new KeyNotFoundException($"Ability on URL \"{url}\" not found");
            }
            else
            {
                string json = await result.Content.ReadAsStringAsync();
                var node = JsonNode.Parse(json!);
                int id = 0;
                string name = "no name";
                string description = "no description";

                id = int.Parse(node!["id"]!.ToString());
                name = node!["name"]!.ToString();
                var names = (JsonArray)node!["names"]!;
                foreach (var _name in names)
                {
                    if (_name!["language"]!["name"]!.ToString() == "en")
                    {
                        name = _name!["name"]!.ToString();
                    }
                }

                var entries = (JsonArray)node!["effect_entries"]!;
                foreach (var entry in entries)
                {
                    if (entry!["language"]!["name"]!.ToString() == "en")
                    {
                        description = entry!["short_effect"]!.ToString();
                    }
                }

                return new Ability(id, name, description);
            }
        }

        public async Task<Pokemon> GetPokemonAsync(string url)
        {
            var result = await httpClient.GetAsync(url);
            if (result.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new KeyNotFoundException($"Pokemon on URL \"{url}\" not found");
            }
            else
            {
                string json = await result.Content.ReadAsStringAsync();
                var node = JsonNode.Parse(json!);
                Regex suburl = new Regex(@"https://pokeapi\.co/api/v2/");
                
                int id = 0;
                string name = "no name";
                int hp = 0;
                int attack = 0;
                List<Ability> abilities = new();
                string? previewLink = "no preview";
                string? fullLink = "no full";

                id = int.Parse(node!["id"]!.ToString());
                name = node!["name"]!.ToString();
                var stats = (JsonArray)node!["stats"]!;
                foreach (var stat in stats)
                {
                    if (stat!["stat"]!["name"]!.ToString() == "hp")
                    {
                        hp = int.Parse(stat!["base_stat"]!.ToString());
                    }
                    else if (stat!["stat"]!["name"]!.ToString() == "attack")
                    {
                        attack = int.Parse(stat!["base_stat"]!.ToString());
                    }
                }

                var abilitiesJson = (JsonArray)node!["abilities"]!;
                foreach (var abilityJson in abilitiesJson)
                {
                    var formattedUrl = suburl.Replace(abilityJson!["ability"]!["url"]!.ToString(), "");
                    var ability = await GetAbilityAsync(formattedUrl);
                    abilities.Add(ability);
                }

                var previewLinkNode = node!["sprites"]!["front_default"];
                var fullLinkNode = node!["sprites"]!["other"]!["official-artwork"]!["front_default"];
                if (previewLinkNode != null)
                    previewLink = previewLinkNode.ToString();
                if (fullLinkNode != null)
                    fullLink = fullLinkNode.ToString();

                return new Pokemon(id, name, hp, attack, abilities, previewLink, fullLink);
            }
        }

        public async Task<Pokemon> GetRandomPokemonAsync()
        {
            var result = await httpClient.GetAsync("pokemon?limit=1292");
            if (result.IsSuccessStatusCode)
            {
                Random rnd = new Random();
                string json = await result.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                var ids = (JsonArray)root!["results"]!;
                var idUrl = ids[rnd.Next(0, ids.Count)]!["url"]!.ToString();
                Regex suburl = new Regex(@"https://pokeapi\.co/api/v2/");
                var formattedUrl = suburl.Replace(idUrl, "");
                return await GetPokemonAsync(formattedUrl);
            }
            else
                throw new Exception("PokeAPI isn't available. Try later");
        }

        public async Task<(int, List<Pokemon>)> GetFilteredPokemonListAsync(string filter, int page)
        {
            // TODO: make pagination
            // TODO: make full getting with no filter options
            var result = await httpClient.GetAsync("pokemon?limit=1292");
            if (result.IsSuccessStatusCode)
            {
                string json = await result.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                var ids = (JsonArray)root!["results"]!;
                filter = (filter != null) ? filter : "";
                var findAll = ids.Where(id => id!["name"]!.ToString().StartsWith(filter.ToLower()));
                var find = findAll.Skip((page - 1) * pageSize).Take(pageSize);
                List<Pokemon> pokemons = new();
                Regex suburl = new Regex(@"https://pokeapi\.co/api/v2/");

                foreach (var p in find)
                {
                    var formattedUrl = suburl.Replace(p!["url"]!.ToString(), "");
                    pokemons.Add(await GetPokemonAsync(formattedUrl));
                }

                return (findAll.Count(), pokemons);
            }
            else
                throw new Exception("PokeAPI isn't available. Try later");
        }

        public async Task SendEmailAsync(string email, string message)
        {
            EmailService service = new EmailService();
            await service.SendEmailAsync(email, message, message);
        }

        public async Task SaveDataToFtp(Pokemon pokemon)
        {
            // auth to FTP
            var ftpClient = new AsyncFtpClient(Config.FtpAddress, Config.FtpUsername, Config.FtpPassword);
            await ftpClient.Connect();
            // format Markdown; pokemon - header (#)
            string mdTemplate = $"# {pokemon.Name}\r\n**HP:** {pokemon.HP}\r\n\r\n**Attack:** {pokemon.Attack}\r\n## Abilities";
            foreach (var ability in pokemon.Abilities)
            {
                mdTemplate += $"\r\n**{ability.Name}.** {ability.Description}\r\n";
            }
            mdTemplate += $"## Image\r\n![image]({pokemon.FullLink})";
            // create Markdown file locally
            var file = File.CreateText($"{pokemon.Name}.md");
            file.Write(mdTemplate);
            file.Flush();
            file.Close();
            // format date for folder name
            string folderName = DateTime.Now.ToString("yyyyMMdd");
            // save file to folder
            await ftpClient.UploadFile($"{pokemon.Name}.md", $"/{folderName}/{pokemon.Name}.md", FtpRemoteExists.Overwrite, true);
            await ftpClient.Disconnect();
            // delete local copy of Markdown file
            File.Delete($"{pokemon.Name}.md");
        }

        public int PageSize { get { return pageSize; } }
    }
}
