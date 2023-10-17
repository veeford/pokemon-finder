using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPokemonControl
{
    public partial class PokemonInfo : UserControl
    {
        //private Pokemon pokemon;
        public PokemonInfo()
        {
            InitializeComponent();
            abilitiesTextBox.Rtf = @"{\rtf1\pc {\b Ability 1:} Ability Text 1}";
        }
    }
}
