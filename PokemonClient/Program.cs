using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json.Nodes;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using pokemon;

namespace CustomPokemonControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public static class PokemonApi
    {
        // List<Pokemon> Pokemons;
        public static Uri Link = new Uri("https://pokeapi.co/api/v2/");
        public static HttpClient client = new HttpClient();
        public static event EventHandler Log = delegate { };

        public static void LogText(LogEventArgs args)
        {
            if (Log != null)
                Log(null, args);
        }

        public static void Fight(Pokemon user, Pokemon cpu, int fight1, int fight2)
        {
            bool isPlayerThinking = fight1 % 2 == fight2 % 2;
            int userHp = user.HP;
            int cpuHp = cpu.HP;
            while (userHp > 0 && cpuHp > 0)
            {
                if (isPlayerThinking)
                {
                    // user
                    cpuHp -= user.Attack;
                    Debug.WriteLine($"{user.Name} attacked {cpu.Name}, attack {user.Attack}, CPU HP {cpuHp}");
                }
                else
                {
                    // computer
                    userHp -= cpu.Attack;
                    Debug.WriteLine($"{cpu.Name} attacked {user.Name}, attack {cpu.Attack}, user HP {userHp}");
                }
                isPlayerThinking = !isPlayerThinking;
            }
            bool isUserWon = cpuHp < userHp;
            Debug.WriteLine($"{(isUserWon ? user.Name : cpu.Name)} won!");

            using (PostgresContext db = new PostgresContext())
            {
                FightsLog log = new FightsLog
                {
                    Winner = (isUserWon ? user.Name : cpu.Name),
                    Loser = (!isUserWon ? user.Name : cpu.Name)
                };
                db.Add(log);
                db.SaveChanges();
            }
        }

        public static async Task<List<Pokemon>> RetrievePokemons(int count, int offset)
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            string jsonObject = await client.GetStringAsync(new Uri(Link, $"pokemon/?offset={offset}&limit={count}"));
            var node = JsonNode.Parse(jsonObject);
            var results = (JsonArray)node!["results"];

            for (int i = 0; i < results.Count; i++)
            {
                int id = int.Parse(results[i]["url"].ToString().TrimEnd('/').Split('/').Last());
                pokemons.Add(await ParsePokemon(id));
                LogText(new LogEventArgs($"Retrieving pokemon ID {id}..."));
            }
            LogText(new LogEventArgs($"Retrieved {results.Count} pokemons."));
            return pokemons;
        }

        public static async Task DownloadImage(string url, string dir)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var fileName = Path.GetFileName(url);
            try
            {
                var fileStream = await client.GetStreamAsync(url);
                var fs = new FileStream(Path.Combine(dir, fileName), FileMode.OpenOrCreate);
                fileStream.CopyTo(fs);
                fs.Close();
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
        }

        public static async Task GetPokemonImages(int id)
        {
            if (!File.Exists(Path.Combine("pokemons/previews", $"{id}.png")))
                await DownloadImage($"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{id}.png", "pokemons/previews");
            if (!File.Exists(Path.Combine("pokemons/full_images", $"{id}.png")))
                await DownloadImage($"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/{id}.png", "pokemons/full_images");
        }

        public static async Task<Ability> ParseAbility(int id)
        {
            string jsonObject = await client.GetStringAsync(new Uri(Link, $"ability/{id}"));
            var node = JsonNode.Parse(jsonObject)!;
            var names = (JsonArray)node!["names"];
            string name = "";
            foreach (var _name in names!)
            {
                if (_name["language"]["name"].ToString() == "en")
                    name = _name["name"].ToString();
            }
            var entries = (JsonArray)node!["effect_entries"];
            string desc = "";
            foreach (var entry in entries!)
            {
                if (entry["language"]["name"].ToString() == "en")
                    desc = entry["short_effect"].ToString();
            }

            return new Ability(id, name, desc);
        }

        public static async Task<Ability> ParseAbility(string fullLink)
        {
            var id = int.Parse(fullLink.TrimEnd('/').Split('/').Last());
            return await ParseAbility(id);
        }

        public static async Task<Pokemon> ParsePokemon(int id)
        {
            string jsonObject = await client.GetStringAsync(new Uri(Link, $"pokemon/{id}"));
            var node = JsonNode.Parse(jsonObject);
            var name = node!["name"]!.ToString();
            var hp = int.Parse(node!["stats"][0]["base_stat"]!.ToString());
            var attack = int.Parse(node!["stats"][1]["base_stat"]!.ToString());
            var previewLinkNode = node!["sprites"]["front_default"];
            var fullLinkNode = node!["sprites"]["other"]["official-artwork"]["front_default"];
            var abilities = new List<Ability>();
            JsonArray rawAbilities = (JsonArray)node!["abilities"];
            for (int i = 0; i < rawAbilities.Count; i++)
                abilities.Add(await ParseAbility(rawAbilities[i]["ability"]["url"]!.ToString()));
            string previewLink = null;
            string fullLink = null;
            if (previewLinkNode != null)
                previewLink = previewLinkNode.ToString();
            if (fullLinkNode != null)
                fullLink = fullLinkNode.ToString();

            return new Pokemon(id, name, hp, attack, abilities, previewLink, fullLink);
        }
    }

    public class LogEventArgs : EventArgs
    {
        static string logText;

        public LogEventArgs(string _logText)
        {
            logText = _logText;
        }

        public string LogText
        {
            get { return logText; }
            set { logText = value; }
        }
    }

    public static class FightData
    {
        public static Pokemon? pokemonPlayer;
        public static Pokemon? pokemonCpu;
        public static int playerMove;
    }

    public static class EmailData
    {
        public static string Email = "vinceford@yandex.ru";
    }
}