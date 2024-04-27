using ScintillaNET;
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
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var FileContent = Parent as Scintilla;

            if (SearchWord.Text.Length == 0)
            {
                MessageBox.Show("Please enter Search Word");
                return;
            }

            if (!FileContent.Text.Contains(SearchWord.Text))
            {
                MessageBox.Show("Search Word not found");
                return;
            }

            FileContent.CurrentPosition = FileContent.Text.IndexOf(SearchWord.Text);

            FileContent.GotoPosition(FileContent.CurrentPosition);
        }

        private void ReplaceBtn_Click(object sender, EventArgs e)
        {
            var FileContent = Parent as Scintilla;

            if (SearchWord.Text.Length == 0)
            {
                MessageBox.Show("Please enter Search Word");
                return;
            }

            if (!FileContent.Text.Contains(SearchWord.Text))
            {
                MessageBox.Show("Search Word not found");
                return;
            }

            FileContent.Text = FileContent.Text.Replace(SearchWord.Text, ReplaceWord.Text);

            MessageBox.Show("Replace Words Finished");
        }

        private void SearchWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBtn_Click(sender, e);
            }
        }

        private void ReplaceWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReplaceBtn_Click(sender, e);
            }
        }
    }
}
