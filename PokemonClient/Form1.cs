
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace CustomPokemonControl
{
    public partial class Form1 : Form
    {
        int currentPage = 1;
        int totalPages = 1;
        HttpClientHandler clientHandler = new HttpClientHandler();
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            client = new HttpClient(clientHandler);
        }
        
        public void Pokemon_Log(object? sender, EventArgs e)
        {
            LogEventArgs a = (LogEventArgs)e;
            status.Text = a.LogText;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            PokemonApi.Log += Pokemon_Log;
            status.Text = "Getting pokemons...";
            var response = await client.GetAsync("http://localhost:5000/pokemon/list?page=1");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                totalPages = int.Parse(root!["count"]!.ToString()) / 10 + 1;
                List<Pokemon>? pokemons = JsonSerializer.Deserialize<List<Pokemon>>(root!["results"]);
                foreach (var pokemon in pokemons!)
                {
                    Debug.WriteLine(pokemon.ToString());
                    await pokemonListBox.Add(pokemon);
                }
            }

            totalPagesLabel.Text = $"/ {totalPages}";
            if (totalPages > 1)
                nextPageButton.Enabled = true;
            prevPageButton.Enabled = false;
            pageNumberTextBox.Text = "1";
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
            pageNumberTextBox.Text = currentPage.ToString();

            pokemonListBox.Clear();

            status.Text = $"Getting pokemons on page {currentPage}...";
            var filter = searchTextBox.Text.Length > 0 ? $"name={searchTextBox.Text}&" : "";
            var response = await client.GetAsync($"http://localhost:5000/pokemon/list?{filter}page={currentPage}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                List<Pokemon>? pokemons = JsonSerializer.Deserialize<List<Pokemon>>(root!["results"]);
                foreach (var pokemon in pokemons!)
                {
                    Debug.WriteLine(pokemon.ToString());
                    await pokemonListBox.Add(pokemon);
                }
                status.Text = "Ready.";
            }
            else
                status.Text = await response.Content.ReadAsStringAsync();
        }

        private async void prevPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
                currentPage--;
            if (currentPage == 1)
                prevPageButton.Enabled = false;
            if (currentPage != totalPages)
                nextPageButton.Enabled = true;
            pageNumberTextBox.Text = currentPage.ToString();
            pokemonListBox.Clear();

            status.Text = $"Getting pokemons on page {currentPage}...";
            var filter = searchTextBox.Text.Length > 0 ? $"name={searchTextBox.Text}&" : "";
            var response = await client.GetAsync($"http://localhost:5000/pokemon/list?{filter}page={currentPage}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                List<Pokemon>? pokemons = JsonSerializer.Deserialize<List<Pokemon>>(root!["results"]);
                foreach (var pokemon in pokemons!)
                {
                    Debug.WriteLine(pokemon.ToString());
                    await pokemonListBox.Add(pokemon);
                }
                status.Text = "Ready.";
            }
            else
                status.Text = await response.Content.ReadAsStringAsync();
        }

        private async void pageNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void pageNumberTextBox_Leave(object sender, EventArgs e)
        {
            currentPage = int.Parse(pageNumberTextBox.Text);
            pokemonListBox.Clear();

            status.Text = $"Getting pokemons on page {currentPage}...";
            var filter = searchTextBox.Text.Length > 0 ? $"name={searchTextBox.Text}&" : "";
            var response = await client.GetAsync($"http://localhost:5000/pokemon/list?{filter}page={currentPage}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                totalPages = int.Parse(root!["count"]!.ToString()) / 10 + 1;
                List<Pokemon>? pokemons = JsonSerializer.Deserialize<List<Pokemon>>(root!["results"]);
                foreach (var pokemon in pokemons!)
                {
                    Debug.WriteLine(pokemon.ToString());
                    await pokemonListBox.Add(pokemon);
                }
                prevPageButton.Enabled = currentPage != 1;
                nextPageButton.Enabled = currentPage != totalPages;
                status.Text = "Ready.";
            }
            else
                status.Text = await response.Content.ReadAsStringAsync();
        }

        private void pokemonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PokemonListBox? list = sender as PokemonListBox;
            pokemonInfo.SetData(list![list.SelectedIndex]);
        }

        private async void searchTextBox_Leave(object sender, EventArgs e)
        {
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            pokemonListBox.Clear();

            status.Text = $"Getting pokemons by \"{searchTextBox.Text}\"...";
            var filter = searchTextBox.Text.Length > 0 ? $"name={searchTextBox.Text}" : "";
            var response = await client.GetAsync($"http://localhost:5000/pokemon/list?{filter}&page=1");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                totalPages = int.Parse(root!["count"]!.ToString()) / 10 + 1;
                List<Pokemon>? pokemons = JsonSerializer.Deserialize<List<Pokemon>>(root!["results"]);
                foreach (var pokemon in pokemons!)
                {
                    Debug.WriteLine(pokemon.ToString());
                    await pokemonListBox.Add(pokemon);
                }
                prevPageButton.Enabled = currentPage != 1;
                nextPageButton.Enabled = currentPage != totalPages;
                totalPagesLabel.Text = $"/ {totalPages}";
                if (totalPages > 1)
                    nextPageButton.Enabled = true;
                prevPageButton.Enabled = false;
                pageNumberTextBox.Text = currentPage.ToString();
                status.Text = "Ready.";
            }
            else
                status.Text = await response.Content.ReadAsStringAsync();
        }

        private void pokemonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}