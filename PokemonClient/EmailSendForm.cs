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
    public partial class EmailSendForm : Form
    {
        public EmailSendForm()
        {
            InitializeComponent();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = sender as TextBox;
            EmailData.Email = text.Text;
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {

        }
    }
}
