using pokemon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomPokemonControl
{
    public partial class PokemonInfo : UserControl
    {
        private Pokemon? pokemonPlayer;
        private Pokemon? pokemonCpu;
        private int fightNumber;

        public Pokemon Pokemon
        {
            get { return pokemonPlayer; }
            set { pokemonPlayer = value; }
        }

        public PokemonInfo()
        {
            InitializeComponent();
            abilitiesTextBox.Rtf = @"{\rtf1\pc {\b Blaze:} Strengthens fire moves to inflict 1.5× damage at 1/3 max HP or less.\par{\b Solar Power:} Increases Special Attack to 1.5× but costs 1/8 max HP after each turn during strong sunlight.}";
        }

        public void SetData(Pokemon pokemon)
        {
            Pokemon = pokemon;
            pokemonName.Text = Pokemon.Name;
            healthInfo.Text = $"Health: {Pokemon.HP}";
            attackInfo.Text = $"Attack: {Pokemon.Attack}";
            Image image;
            if (File.Exists(Path.Combine("pokemons/full_images", $"{Pokemon.Id}.png")))
                image = Image.FromFile(Path.Combine("pokemons/full_images", $"{Pokemon.Id}.png"));
            else
                image = Image.FromFile("noPokemon.png");
            pictureBox1.Image = new Bitmap(image, pictureBox1.Size);
            string abilities = @"{\rtf1\pc" + '\n';
            foreach (var ability in Pokemon.Abilities)
            {
                abilities += @"{\pard \fs28 \b " + ability.Name + @"\par}" + '\n';
                abilities += @"{\pard \fs18 \b0" + '\n' + ability.Description + "\n" + @"\par}" + '\n';
            }
            abilities += "}";
            abilitiesTextBox.Rtf = abilities;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PokemonApi.LogText(new LogEventArgs("Init fight..."));
            var response = await PokemonApi.client.GetAsync($"http://localhost:5000/fight?player={pokemonPlayer.Id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                List<Pokemon>? fightInfo = JsonSerializer.Deserialize<List<Pokemon>>(json);
                pokemonCpu = fightInfo![1];
            }
            else
                PokemonApi.LogText(new LogEventArgs(await response.Content.ReadAsStringAsync()));

            FightForm fightForm = new FightForm();
            FightData.pokemonPlayer = pokemonPlayer;
            FightData.pokemonCpu = pokemonCpu;
            fightForm.Show();
        }

        /*private void fightTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = sender as TextBox;
            bool validNum = int.TryParse(text.Text, out fightNumber);
            fightButton.Enabled = validNum && fightNumber >= 1 && fightNumber <= 10;
        }*/

        private async void fastFightButton_Click(object sender, EventArgs e)
        {
            PokemonApi.LogText(new LogEventArgs("Init fast fight..."));
            var response = await PokemonApi.client.GetAsync($"http://localhost:5000/fight/fast?player={pokemonPlayer.Id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var root = JsonNode.Parse(json);
                int winnerId = int.Parse(root!["winnerId"]!.ToString());
                EmailSendForm emailSendForm = new EmailSendForm();
                var result = emailSendForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    await PokemonApi.client.GetAsync($"http://localhost:5000/send?email={EmailData.Email}");
                }
            }
            else
                PokemonApi.LogText(new LogEventArgs(await response.Content.ReadAsStringAsync()));
        }
    }
}
