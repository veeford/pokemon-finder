using CustomPokemonControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon
{
    public partial class ThrowDice : Form
    {
        public ThrowDice()
        {
            InitializeComponent();
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = sender as TextBox;
            bool validNum = int.TryParse(text!.Text, out FightData.playerMove);
            makeMoveButton.Enabled = validNum && FightData.playerMove >= 1 && FightData.playerMove <= 10;
        }
    }
}
