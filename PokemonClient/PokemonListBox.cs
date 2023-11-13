using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPokemonControl
{
    public class PokemonListBox : ListBox
    {
        private Font pokemonFont;
        private int ItemMargin = 4;
        private List<Pokemon> pokemons;

        public PokemonListBox()
        {
            pokemonFont = new Font(Font.FontFamily, 20f, FontStyle.Bold, GraphicsUnit.Pixel);
            pokemons = new List<Pokemon>();
        }

        public async Task Add(Pokemon pokemon)
        {
            await PokemonApi.GetPokemonImages(pokemon.Id);
            Items.Add(pokemon.Name);
            pokemons.Add(pokemon);
        }

        public Pokemon this[int index]
        {
            get => pokemons[index];
            set => pokemons[index] = value;
        }

        public void Clear()
        {
            Items.Clear();
            pokemons.Clear();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (Items.Count > 0)
            {
                e.DrawBackground();
                Image image;
                if (File.Exists(Path.Combine("pokemons/previews", $"{pokemons[e.Index].Id}.png")))
                    image = Image.FromFile(Path.Combine("pokemons/previews", $"{pokemons[e.Index].Id}.png"));
                else
                    image = Image.FromFile("noPokemon.png");
                //Image image = Image.FromFile("4.png");
                e.Graphics.DrawImage(image, new Rectangle(e.Bounds.Left, e.Bounds.Top, 64, 64),
                    new Rectangle(0, 0, 96, 96), GraphicsUnit.Pixel);
                var chars = "";
                for (int i = 0; i < pokemons[e.Index].Abilities.Count; i++)
                {
                    chars += pokemons[e.Index].Abilities[i].Name;
                    if (i != pokemons[e.Index].Abilities.Count - 1)
                        chars += ", ";
                }
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.DrawString(pokemons[e.Index].Name, pokemonFont, SystemBrushes.HighlightText, e.Bounds.Left + 64, e.Bounds.Top + ItemMargin);
                    e.Graphics.DrawString(chars, Font, SystemBrushes.HighlightText, e.Bounds.Left + 64, e.Bounds.Top + ItemMargin + 32);
                }
                else
                {
                    e.Graphics.DrawString(pokemons[e.Index].Name, pokemonFont, SystemBrushes.WindowText, e.Bounds.Left + 64, e.Bounds.Top + ItemMargin);
                    e.Graphics.DrawString(chars, Font, SystemBrushes.WindowText, e.Bounds.Left + 64, e.Bounds.Top + ItemMargin + 32);
                }
                e.DrawFocusRectangle();
            }
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            string text = (string)Items[e.Index];
            SizeF textSize = e.Graphics.MeasureString(text, pokemonFont);
            e.ItemWidth = Width;
            //e.ItemHeight = (int)textSize.Height + 2 * ItemMargin;
            e.ItemHeight = 64;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }
    }
}
