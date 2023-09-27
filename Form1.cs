using System.Diagnostics;
using System.Text.Json;

namespace pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            currentStatus.Text = "Getting pokemons' list...";
            pokemons = await GetPokemonsAsync();
            currentStatus.Text = $"Got {pokemons.Count} pokemon(s).";
            pokemonsListView.Items.Clear();

            foreach (var pokemon in pokemons)
                pokemonsListView.Items.Add(pokemon.Name);
        }

        public async Task<List<Pokemon>> GetPokemonsAsync()
        {
            HttpClient client = new HttpClient();

            int? pokemonsAmount = 0;
            HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                var deserializeOptions = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                RootClass? r = JsonSerializer.Deserialize<RootClass>(json, deserializeOptions);
                pokemonsAmount = r?.Count;
            }
            else
                throw new Exception("Error: can't get pokemons amount.");

            response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/?limit={pokemonsAmount}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                var deserializeOptions = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                RootClass? r = JsonSerializer.Deserialize<RootClass>(json, deserializeOptions);
                return r.Results;
            }
            else
                throw new Exception("Error: can't get pokemons' list.");
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            currentStatus.Text = "Searching...";
            var searching = searchTextBox.Text.Trim().ToLower();
            var filteredPokemonsList = pokemons.FindAll((name) => name.Name.StartsWith(searching));
            pokemonsListView.Items.Clear();

            foreach (var pokemon in filteredPokemonsList)
                pokemonsListView.Items.Add(pokemon.Name);
            currentStatus.Text = $"Found {filteredPokemonsList.Count} item(s).";
        }
    }
}