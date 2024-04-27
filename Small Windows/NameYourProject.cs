using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElroubyLessCore.Small_Windows
{
    public partial class NameYourProject : Form
    {
        public NameYourProject()
        {
            InitializeComponent();
        }

        private void TypeNameHere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_Click(sender, e);
            }
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            if (TypeNameHere.Text.Length <= 2)
            {
                MessageBox.Show("You have to write name with more than 2 characters");
                return;
            }

            Close();
        }
    }
}
