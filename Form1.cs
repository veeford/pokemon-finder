
using System.Diagnostics;
using System.Text.Json.Nodes;

namespace CustomPokemonControl
{
    public partial class Form1 : Form
    {
        int currentPage = 1;
        int totalPages = 1;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Pokemon_Log(object? sender, EventArgs e)
        {
            LogEventArgs a = (LogEventArgs)e;
            status.Text = a.LogText;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            int pokemonsAmount = 0;
            status.Text = "Getting pokemons' amount...";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var node = JsonNode.Parse(json);
                    pokemonsAmount = int.Parse(node!["count"]!.ToString());
                }
                else
                    throw new Exception("Error: can't get pokemons amount.");
            }
            status.Text = $"Got {pokemonsAmount} pokemons.";

            PokemonApi.Log += Pokemon_Log;
            totalPages = pokemonsAmount / 10 + 1;
            pagesLabel.Text = $"/ {totalPages}";
            if (totalPages > 1)
                nextPageButton.Enabled = true;
            Task<List<Pokemon>> retrieve = PokemonApi.RetrievePokemons(10, 0);
            var page = await retrieve;
            status.Text = "Retrievied 10 pokemons.";
            foreach (var pokemon in page)
            {
                await pokemonListBox1.Add(pokemon);
                status.Text = $"Adding pokemon with ID {pokemon.Id}...";
            }
            status.Text = "Ready.";
        }

        private async void nextPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage != totalPages)
                currentPage++;
            if (currentPage == totalPages)
                nextPageButton.Enabled = false;
            if (currentPage != 1)
                prevPageButton.Enabled = true;
            selectedPage.Text = currentPage.ToString();

            pokemonListBox1.Clear();
            Task<List<Pokemon>> retrieve = PokemonApi.RetrievePokemons(10, (currentPage - 1) * 10);
            var page = await retrieve;
            foreach (var pokemon in page)
            {
                await pokemonListBox1.Add(pokemon);
                status.Text = $"Adding pokemon with ID {pokemon.Id}...";
            }
            status.Text = "Ready.";
        }

        private async void prevPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
                currentPage--;
            if (currentPage == 1)
                prevPageButton.Enabled = false;
            if (currentPage != totalPages)
                nextPageButton.Enabled = true;
            selectedPage.Text = currentPage.ToString();

            pokemonListBox1.Clear();
            Task<List<Pokemon>> retrieve = PokemonApi.RetrievePokemons(10, (currentPage - 1) * 10);
            var page = await retrieve;
            foreach (var pokemon in page)
            {
                await pokemonListBox1.Add(pokemon);
                status.Text = $"Adding pokemon with ID {pokemon.Id}...";
            }
            status.Text = "Ready.";
        }

        private async void selectedPage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void selectedPage_Leave(object sender, EventArgs e)
        {
            currentPage = int.Parse(selectedPage.Text);
            prevPageButton.Enabled = currentPage != 1;
            nextPageButton.Enabled = currentPage != totalPages;
            pokemonListBox1.Clear();
            Task<List<Pokemon>> retrieve = PokemonApi.RetrievePokemons(10, (currentPage - 1) * 10);
            var page = await retrieve;
            foreach (var pokemon in page)
            {
                await pokemonListBox1.Add(pokemon);
                status.Text = $"Image not found locally for pokemon ID {pokemon.Id}, retrieving...";
            }
            status.Text = "Ready.";
        }
    }
}