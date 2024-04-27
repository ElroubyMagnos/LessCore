using CefSharp;
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

namespace ElroubyLessCore.Html_Windows
{
    public partial class ClassSelectPreview : Form
    {
        public ClassSelectPreview()
        {
            InitializeComponent();

            HtmlWrite.Lexer = Lexer.Html;

            HtmlWrite.Styles[Style.Html.Attribute].ForeColor = Color.Red;

            HtmlWrite.Styles[Style.Html.Tag].ForeColor = Color.Blue;

            HtmlWrite.Styles[Style.Html.Value].ForeColor = Color.Brown;
            HtmlWrite.Styles[Style.Html.Value].Size = HtmlWrite.Styles[Style.Html.Value].Size + 1;

            HtmlWrite.Styles[Style.Html.Comment].ForeColor = Color.Green;
            HtmlWrite.Styles[Style.Html.Comment].Size = HtmlWrite.Styles[Style.Html.Comment].Size + 3;

            HtmlWrite.Styles[Style.Html.Default].ForeColor = Color.Black;

            HtmlWrite.Styles[Style.Html.DoubleString].ForeColor = Color.OrangeRed;

            HtmlWrite.Styles[Style.Html.SingleString].ForeColor = Color.OrangeRed;

            HtmlWrite.Styles[Style.BraceLight].BackColor = Color.LightGray;
            HtmlWrite.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            HtmlWrite.Styles[Style.BraceBad].ForeColor = Color.Red;
        }

        public void HtmlWrite_TextChanged(object sender, EventArgs e)
        {
            string CSS = $"<style>" +
                $"{editorcontainer.Controls[0].Text}" +
                $"</style>\n";
            Preview.LoadHtml(CSS + HtmlWrite.Text);
        }

        private void HtmlWrite_KeyUp(object sender, KeyEventArgs e)
        {
            var CP = HtmlWrite.CurrentPosition;

            var LastLineTabCount = HtmlWrite.Lines[HtmlWrite.CurrentLine - 1].Text.Split('\t').Count() - 1;
            var CurrentLineTabCount = HtmlWrite.Lines[HtmlWrite.CurrentLine].Text.Split('\t').Count() - 1;

            if (LastLineTabCount == 0)
            {
                LastLineTabCount = (HtmlWrite.Lines[HtmlWrite.CurrentLine - 1].Text.Split(' ').Count() / 2) - 1;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (HtmlWrite.Text[HtmlWrite.CurrentPosition] == '<')
                {
                    for (int i = 0; i < LastLineTabCount; i++)
                    {
                        HtmlWrite.InsertText(HtmlWrite.CurrentPosition, "\t");
                    }

                    HtmlWrite.InsertText(HtmlWrite.CurrentPosition, "\t\n");

                    HtmlWrite.GotoPosition(CP + LastLineTabCount + 2);
                    return;
                }
                NewLine();

            }

            void RefreshTabs()
            {
                LastLineTabCount = HtmlWrite.Lines[HtmlWrite.CurrentLine - 1].Text.Split('\t').Count() - 1;
                CurrentLineTabCount = HtmlWrite.Lines[HtmlWrite.CurrentLine].Text.Split('\t').Count() - 1;
            }

            void NewLine()
            {
                if (HtmlWrite.CurrentLine > -1)
                {
                    if (LastLineTabCount != CurrentLineTabCount)
                    {
                        for (int i = 0; i < LastLineTabCount - CurrentLineTabCount; i++)
                        {
                            HtmlWrite.InsertText(CP, "\t");
                        }

                        HtmlWrite.GotoPosition(HtmlWrite.CurrentPosition + (LastLineTabCount - CurrentLineTabCount));
                    }
                }

                if (HtmlWrite.Text.Length != CP && HtmlWrite.Text[CP] == '}')
                {
                    HtmlWrite.InsertText(CP, "\n");

                    RefreshTabs();

                    for (int i = 0; i < LastLineTabCount + 1; i++)
                    {
                        HtmlWrite.InsertText(CP, "\t");

                    }

                    HtmlWrite.GotoPosition(HtmlWrite.CurrentPosition + LastLineTabCount + 1);
                }

            }
        }

        private void HtmlWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=')
            {
                HtmlWrite.InsertText(HtmlWrite.CurrentPosition, "=\"\"");

                HtmlWrite.GotoPosition(HtmlWrite.CurrentPosition + 2);

                e.Handled = true;
            }
            else if (e.KeyChar == '>')
            {
                var NameOfTag = GetNameOfTag();

                if (NameOfTag.Length == 0)
                {
                    return;
                }

                HtmlWrite.InsertText(HtmlWrite.CurrentPosition, $"></{NameOfTag}>");

                e.Handled = true;

                HtmlWrite.GotoPosition(HtmlWrite.CurrentPosition + 1);
            }

            string GetNameOfTag()
            {
                int BackCount = -1;

                for (int i = HtmlWrite.CurrentPosition - 1; i >= 0; i--)
                {
                    if (HtmlWrite.Text[i] == '<')
                    {
                        i++;
                        BackCount = i;
                        break;
                    }
                }

                if (BackCount == -1)
                    return "";

                string Tag = "";

                for (int i = BackCount; i < HtmlWrite.CurrentPosition; i++)
                {
                    Tag += HtmlWrite.Text[i];
                }

                return Tag;
            }
        }
    }
}
