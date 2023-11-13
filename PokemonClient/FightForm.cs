using CustomPokemonControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon
{
    public partial class FightForm : Form
    {
        public FightForm()
        {
            InitializeComponent();
        }

        private async void stepButton_Click(object sender, EventArgs e)
        {
            ThrowDice throwDice = new ThrowDice();
            var result = throwDice.ShowDialog();
            if (result == DialogResult.OK)
            {
                var content = new StringContent(FightData.playerMove.ToString());
                var resp = await PokemonApi.client.PostAsync($"http://localhost:5000/fight/{FightData.playerMove}", content);
                string log = await resp.Content.ReadAsStringAsync();
                var data = JsonNode.Parse(log);
                bool isPlayerOrder = bool.Parse(data!["isPlayerMove"]!.ToString());
                int rounds = int.Parse(data!["rounds"]!.ToString());
                int playerHp = int.Parse(data!["playerHp"]!.ToString());
                int cpuHp = int.Parse(data!["cpuHp"]!.ToString());
                string order = isPlayerOrder ? "you attacked CPU" : "CPU attacked you";
                logListBox.Items.Add($"Round {rounds}, {order}; your HP = {playerHp}, CPU HP = {cpuHp}");

                if (!(playerHp > 0 && cpuHp > 0))
                {
                    MessageBox.Show(playerHp > 0 ? "You win!" : "You lose!", "Fight", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private async void FightForm_Load(object sender, EventArgs e)
        {
            pokemonPlayerNameLabel.Text = FightData.pokemonPlayer!.Name;
            pokemonPlayerHpLabel.Text = $"HP: {FightData.pokemonPlayer.HP}";
            pokemonPlayerAttackLabel.Text = $"Attack: {FightData.pokemonPlayer.Attack}";
            Image imagePlayer;
            while (!File.Exists(Path.Combine("pokemons/full_images", $"{FightData.pokemonPlayer.Id}.png")))
            {
                await PokemonApi.GetPokemonImages(FightData.pokemonPlayer.Id);
            }
            imagePlayer = Image.FromFile(Path.Combine("pokemons/full_images", $"{FightData.pokemonPlayer.Id}.png"));
            pokemonPlayerImage.Image = new Bitmap(imagePlayer, pokemonPlayerImage.Size);

            pokemonCpuNameLabel.Text = FightData.pokemonCpu!.Name;
            pokemonCpuHpLabel.Text = $"HP: {FightData.pokemonCpu.HP}";
            pokemonCpuAttackLabel.Text = $"Attack: {FightData.pokemonCpu.Attack}";
            Image imageCpu;
            while (!File.Exists(Path.Combine("pokemons/full_images", $"{FightData.pokemonCpu.Id}.png")))
            {
                await PokemonApi.GetPokemonImages(FightData.pokemonCpu.Id);
            }
            imageCpu = Image.FromFile(Path.Combine("pokemons/full_images", $"{FightData.pokemonCpu.Id}.png"));
            pokemonCpuImage.Image = new Bitmap(imageCpu, pokemonCpuImage.Size);
        }
    }
}
