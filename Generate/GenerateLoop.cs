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

namespace ElroubyLessCore
{
    public partial class GenerateLoop : Form
    {
        public GenerateLoop()
        {
            InitializeComponent();
        }

        private void GenerateLoop_Load(object sender, EventArgs e)
        {
            AppendColorToScintilla(LoopPreview);
            AppendColorToScintilla(CSSContainer);

            if (File.Exists("temp.css"))
            {
                File.Delete("temp.css");
            }
        }
        void AppendColorToScintilla(Scintilla FileContent)
        {
            FileContent.Styles[Style.Css.Attribute].ForeColor = Color.Red;

            FileContent.Styles[Style.Css.Variable].ForeColor = Color.Blue;

            FileContent.Styles[Style.Css.Value].ForeColor = Color.Brown;
            FileContent.Styles[Style.Css.Value].Size = FileContent.Styles[Style.Css.Value].Size + 1;

            FileContent.Styles[Style.Css.Class].BackColor = Color.Yellow;

            FileContent.Styles[Style.Css.Comment].ForeColor = Color.Green;
            FileContent.Styles[Style.Css.Comment].Size = FileContent.Styles[Style.Css.Comment].Size + 3;

            FileContent.Styles[Style.Css.Default].ForeColor = Color.Black;

            FileContent.Styles[Style.Css.DoubleString].ForeColor = Color.OrangeRed;

            FileContent.Styles[Style.Css.ExtendedIdentifier].ForeColor = Color.Yellow;

            FileContent.Styles[Style.Css.ExtendedPseudoClass].ForeColor = Color.Red;

            FileContent.Styles[Style.Css.ExtendedPseudoElement].ForeColor = Color.DarkBlue;

            FileContent.Styles[Style.Css.Media].ForeColor = Color.Violet;

            FileContent.Styles[Style.Css.Operator].Bold = true;
            FileContent.Styles[Style.Css.Operator].Size++;

            FileContent.Styles[Style.Css.SingleString].ForeColor = Color.OrangeRed;

            FileContent.Styles[Style.BraceLight].BackColor = Color.LightGray;
            FileContent.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            FileContent.Styles[Style.BraceBad].ForeColor = Color.Red;
        }

        private async void ToCSS_Click(object sender, EventArgs e)
        {
            if (LoopPreview.Text.Length == 0)
            {
                MessageBox.Show("Nothing to Show");
                return;
            }

            if (File.Exists("temp.less"))
            {
                File.Delete("temp.less");
            }

            if (File.Exists("temp.css"))
            {
                File.Delete("temp.css");
            }

            File.WriteAllText("temp.less", LoopPreview.Text);

            await Main.ConvertLessToCSS("temp.less", "temp.css");

            CheckIt = false;
        }

        private void EntryToLoop_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text.Length == 0)
                {
                    MessageBox.Show("Some Field is empty");
                    return;
                }
            }

            LoopPreview.Text = $@".{LoopName.Text}({LoopCount.Text});

.{LoopName.Text}(@n, @i: {PropertyValue.Text}) when (@i =< @n) 
{{
    .{PropertyName.Text}-@{{i}} 
    {{
        {PropertyName.Text}: @i;
    }}
    .{LoopName.Text}(@n, (@i + {Increment.Text}));
}}";
        }
        bool CheckIt = false;
        private void TimerForConvert_Tick(object sender, EventArgs e)
        {
            if (!CheckIt)
            {
                if (File.Exists("temp.css"))
                {
                    CheckIt = true;
                    CSSContainer.Text = File.ReadAllText("temp.css");
                }
            }
        }

        private void CopyCSS_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CSSContainer.Text);
        }

        private void CopyLoop_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LoopPreview.Text);
        }
    }
}
