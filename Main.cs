using CefSharp;
using ElroubyLessCore.Core;
using ElroubyLessCore.Core.Classes;
using ElroubyLessCore.Html_Windows;
using ElroubyLessCore.Small_Windows;
using ElroubyLessCore.Tables;
using Microsoft.EntityFrameworkCore;
using ScintillaNET;

namespace ElroubyLessCore
{
    public partial class Main : Form
    {
        public static Main MainForm { get; set; }
        public Main()
        {
            InitializeComponent();

            MainForm = this;
        }
        private async void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\Users\\Sondos\\AppData\\Roaming\\npm\\node_modules\\less\\"))
            {
                MessageBox.Show("Less is not installed globally on this system, You can't use this program");
                Application.Exit();
            }

            CheckForIllegalCrossThreadCalls = false;

            var lesscore = new lesscore();

            var projexist = await lesscore.Projects.FirstOrDefaultAsync();

            if (projexist != null)
            {
                LoadProject(projexist.ProjPath);
            }

            var filesexist = await lesscore.Files.ToListAsync();

            foreach (var file in filesexist)
            {
                OpenFileVOID(file.Path);
            }

            MainTabs_SelectedIndexChanged(sender, e);
        }
        private async void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ProjectName.Text.Length == 0)
            {
                return;
            }

            Loading loading = new Loading();
            Thread T = new Thread(() =>
            {
                loading.Show();
                loading.BringToFront();
            });

            T.Start();

            var lesscore = new lesscore();
            loading.PB.Value += 3;

            lesscore.Projects.RemoveRange(lesscore.Projects);
            loading.PB.Value += 7;
            var ProjectCore = new Project()
            {
                ProjName = ProjectName.Text,
                ProjPath = ProjectPath.Text
            };
            loading.PB.Value += 10;
            await lesscore.Projects.AddAsync(ProjectCore);
            loading.PB.Value += 10;
            await lesscore.SaveChangesAsync();
            loading.PB.Value += 20;
            var projfin = lesscore.Projects.FirstOrDefault(x => x.ProjName == ProjectName.Text
            && x.ProjPath == ProjectPath.Text);
            loading.PB.Value += 10;
            lesscore.Files.RemoveRange(lesscore.Files);
            loading.PB.Value += 20;
            foreach (TabPage tp in MainTabs.TabPages)
            {
                var FileCore = new FileSave()
                {
                    Name = tp.Text,
                    Path = tp.Name,
                    Text = tp.Text,
                    ProjID = projfin.ID
                };

                await lesscore.Files.AddAsync(FileCore);
            }
            loading.PB.Value += 20;

            if (MainTabs.TabPages.Count > 0)
            {
                await lesscore.SaveChangesAsync();
            }

            loading.PB.Value += 5;

            loading.Close();
        }
        private void OpenProject_Click(object sender, EventArgs e)
        {
            if (OpenProjectDialog.ShowDialog() == DialogResult.OK)
            {
                LoadProject(OpenProjectDialog.FileName);
            }
        }

        async void LoadProject(string PathOfLesscore)
        {
            if (!File.Exists(PathOfLesscore))
            {
                MessageBox.Show("Can't load file");
                return;
            }

            ProjectExplorer.Items.Clear();

            MainTabs.TabPages.Clear();

            string AllFiles = await File.ReadAllTextAsync(PathOfLesscore);

            if (AllFiles == null || AllFiles.Length == 0)
            {
                MessageBox.Show("Can't load file");
                return;
            }

            ProjectName.Text = PathOfLesscore.Split('\\').Last().Split('.')[0];
            ProjectPath.Text = PathOfLesscore;
            if (!ExplorerTimer.Enabled)
            {
                ExplorerTimer.Start();
            }

            string TwoBrackets = AllFiles.Substring(AllFiles.IndexOf("FileList=>")).Split('{', '}')[1];

            string[] Files = TwoBrackets.Split(',');

            int i = 0;

            foreach (var filename in Files)
            {
                if (filename.Length > 0)
                {
                    if (filename.Contains("\\"))
                    {
                        if (File.Exists(filename))
                        {
                            FileWithNumber fwn = new FileWithNumber()
                            {
                                ID = i,
                                Name = filename.Split('\\').Last(),
                                Path = filename
                            };

                            ProjectExplorer.Content.Add(fwn);
                        }
                    }
                }
                i++;
            }

        }

        private void ProjectExplorer_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTabs_SelectedIndexChanged(sender, e);
        }

        private void ProjectExplorer_DoubleClick(object sender, EventArgs e)
        {
            foreach (FileInfo file in new DirectoryInfo(RemoveLastFile(ProjectPath.Text)).GetFiles())
            {
                if (file.Name == ProjectExplorer.SelectedItem.ToString())
                {
                    OpenFileVOID(file.FullName);
                    break;
                }
            }
        }

        void OpenFileVOID(string Path)
        {
            if (!File.Exists(Path))
            {
                MessageBox.Show("Can't reach the file!");
                return;
            }

            foreach (TabPage tp in MainTabs.TabPages)
            {
                if (tp.Name == Path)
                {
                    MainTabs.SelectedTab = tp;
                    MessageBox.Show("File already open");
                    return;
                }
            }

            TabPage tb = new TabPage();
            Scintilla s = new Scintilla();

            s.TextChanged += FileContent_Do;
            s.TextChanged += FileContent_TextChanged;

            s.Click += FileContent_Do;
            s.KeyUp += FileContent_KeyUp;

            s.Text = File.ReadAllText(Path);

            tb.Controls.Add(s);

            s.Dock = DockStyle.Fill;

            MainTabs.TabPages.Add(tb);
            tb.Name = Path;
            tb.Text = Path.Split('\\').Last();

            MainTabs.SelectedTab = tb;

            s.Lexer = Lexer.Css;

            s.Styles[Style.Css.Attribute].ForeColor = Color.Red;

            s.Styles[Style.Css.Variable].ForeColor = Color.Blue;

            s.Styles[Style.Css.Value].ForeColor = Color.Brown;
            s.Styles[Style.Css.Value].Size = s.Styles[Style.Css.Value].Size + 1;

            s.Styles[Style.Css.Class].BackColor = Color.Yellow;

            s.Styles[Style.Css.Comment].ForeColor = Color.Green;
            s.Styles[Style.Css.Comment].Size = s.Styles[Style.Css.Comment].Size + 3;

            s.Styles[Style.Css.Default].ForeColor = Color.Black;

            s.Styles[Style.Css.DoubleString].ForeColor = Color.OrangeRed;

            s.Styles[Style.Css.ExtendedIdentifier].ForeColor = Color.Yellow;

            s.Styles[Style.Css.ExtendedPseudoClass].ForeColor = Color.Red;

            s.Styles[Style.Css.ExtendedPseudoElement].ForeColor = Color.DarkBlue;

            s.Styles[Style.Css.Media].ForeColor = Color.Violet;

            s.Styles[Style.Css.Operator].Bold = true;
            s.Styles[Style.Css.Operator].Size++;

            s.Styles[Style.Css.SingleString].ForeColor = Color.OrangeRed;

            s.Styles[Style.BraceLight].BackColor = Color.LightGray;
            s.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            s.Styles[Style.BraceBad].ForeColor = Color.Red;

            s.UpdateUI += scintilla_UpdateUI;

            s.Text = s.Text.Replace("  ", "\t");
        }

        int lastCaretPos = 0;

        private void scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            var scintilla = sender as Scintilla;
            // Has the caret changed position?
            var caretPos = scintilla.CurrentPosition;
            if (lastCaretPos != caretPos)
            {
                lastCaretPos = caretPos;
                var bracePos1 = -1;
                var bracePos2 = -1;

                // Is there a brace to the left or right?
                if (caretPos > 0 && IsBrace(scintilla.GetCharAt(caretPos - 1)))
                    bracePos1 = (caretPos - 1);
                else if (IsBrace(scintilla.GetCharAt(caretPos)))
                    bracePos1 = caretPos;

                if (bracePos1 >= 0)
                {
                    // Find the matching brace
                    bracePos2 = scintilla.BraceMatch(bracePos1);
                    if (bracePos2 == Scintilla.InvalidPosition)
                        scintilla.BraceBadLight(bracePos1);
                    else
                        scintilla.BraceHighlight(bracePos1, bracePos2);
                }
                else
                {
                    // Turn off brace matching
                    scintilla.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition);
                }
            }
        }

        private static bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                    return true;
            }

            return false;
        }

        private int maxLineNumberCharLength;
        private void FileContent_TextChanged(object sender, EventArgs e)
        {
            var scintilla = sender as Scintilla;

            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void FileContent_KeyUp(object sender, KeyEventArgs e)
        {
            var FileContent = sender as Scintilla;

            bool IsContainsBrackets = FileContent.Text.Contains("{") && FileContent.Text.Contains("}");
            string[] SeperatedDoc = FileContent.Text.Split('{', '}');
            bool IsValidBracketsInDocument = SeperatedDoc.Count() % 2 == 1;

            var CP = FileContent.CurrentPosition;

            var LastLineTabCount = FileContent.Lines[FileContent.CurrentLine - 1].Text.Split('\t').Count() - 1;
            var CurrentLineTabCount = FileContent.Lines[FileContent.CurrentLine].Text.Split('\t').Count() - 1;


            if (e.Shift && e.KeyCode == Keys.OemSemicolon)
            {
                FileContent.InsertText(CP, " ");

                FileContent.GotoPosition(FileContent.CurrentPosition + 1);
            }
            else if (e.KeyCode == Keys.OemSemicolon)
            {
                FileContent.InsertText(FileContent.CurrentPosition, "\n");
                FileContent.GotoPosition(FileContent.CurrentPosition + 1);

                RefreshTabs();

                if (FileContent.CurrentLine > -1)
                {
                    if (LastLineTabCount != CurrentLineTabCount)
                    {
                        for (int i = 0; i < LastLineTabCount - CurrentLineTabCount; i++)
                        {
                            FileContent.InsertText(FileContent.CurrentPosition, "\t");
                        }

                        FileContent.GotoPosition(FileContent.CurrentPosition + (LastLineTabCount - CurrentLineTabCount));
                    }
                }
            }
            else if (e.KeyCode == Keys.OemOpenBrackets)
            {
                FileContent.InsertText(CP, "}");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                NewLine();
            }

            if (FileContent.CurrentPosition == FileContent.Text.Length)
                return;

            char TouchedChar = FileContent.Text[FileContent.CurrentPosition];

            if (IsValidBracketsInDocument)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    switch (TouchedChar)
                    {
                        case '}':
                            FileContent.InsertText(FileContent.CurrentPosition, "\n");
                            FileContent.InsertText(FileContent.CurrentPosition, "\t");

                            FileContent.GotoPosition(FileContent.CurrentPosition + 1);

                            for (int i = 0; i < LastLineTabCount - CurrentLineTabCount; i++)
                            {
                                FileContent.InsertText(FileContent.CurrentPosition + 1, "\t");
                            }
                            break;
                    }
                }
            }

            bool CheckLineBetweenBrackets(string Content)
            {
                if (IsValidBracketsInDocument)
                {
                    for (int i = 0; i < SeperatedDoc.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            if (SeperatedDoc[i].Contains(Content))
                            {
                                return true;
                            }
                        }
                    }
                }
                else return false;

                return false;
            }
            void RefreshTabs()
            {
                LastLineTabCount = FileContent.Lines[FileContent.CurrentLine - 1].Text.Split('\t').Count() - 1;
                CurrentLineTabCount = FileContent.Lines[FileContent.CurrentLine].Text.Split('\t').Count() - 1;
            }
            void NewLine()
            {
                if (FileContent.CurrentLine > -1)
                {
                    if (LastLineTabCount != CurrentLineTabCount)
                    {
                        for (int i = 0; i < LastLineTabCount - CurrentLineTabCount; i++)
                        {
                            FileContent.InsertText(CP, "\t");
                        }

                        FileContent.GotoPosition(FileContent.CurrentPosition + (LastLineTabCount - CurrentLineTabCount));
                    }
                }

                if (FileContent.Text.Length != CP && FileContent.Text[CP] == '}')
                {
                    FileContent.InsertText(CP, "\n");

                    RefreshTabs();

                    for (int i = 0; i < LastLineTabCount + 1; i++)
                    {
                        FileContent.InsertText(CP, "\t");

                    }

                    FileContent.GotoPosition(FileContent.CurrentPosition + LastLineTabCount + 1);
                }

            }
        }
        private void FileContent_Do(object sender, EventArgs e)
        {
            if (MainTabs.SelectedTab == null || MainTabs.SelectedTab.Controls.Count == 0)
                return;

            var FileContent = sender as Scintilla;

            var SelectedPathFile = MainTabs.SelectedTab.Name;

            if ((MainTabs.SelectedTab.Controls[0] as Scintilla) != FileContent)
            {
                return;
            }

            MainTabs.SelectedTab.Text = MainTabs.SelectedTab.Text.Replace("*", "");

            if (File.ReadAllText(SelectedPathFile) != FileContent.Text)
                MainTabs.SelectedTab.Text = MainTabs.SelectedTab.Text + "*";
        }
        private void NewProject_Click(object sender, EventArgs e)
        {
            var naming = new NameYourProject();
            naming.ShowDialog();
            if (naming.TypeNameHere.Text.Length == 0)
            {
                return;
            }
            if (NewProjectDialog.ShowDialog() == DialogResult.OK)
            {
                var ourpath = NewProjectDialog.SelectedPath + $"\\{naming.TypeNameHere.Text}\\";

                if (Directory.Exists(ourpath))
                {
                    if (new DirectoryInfo(ourpath).GetFiles().Count() != 0)
                    {
                        MessageBox.Show("Path is not empty");
                        return;
                    }
                }

                Directory.CreateDirectory(ourpath);

                File.WriteAllText(ourpath + "\\main.less", "Type your code here");
                File.WriteAllText(ourpath + naming.TypeNameHere.Text + ".lesscore", $"NameOfProject={naming.TypeNameHere.Text}\n" +
                    "FileList=>" +
                    $"{{{ourpath + "\\main.less"}}}");

                ProjectName.Text = naming.TypeNameHere.Text;
                ProjectPath.Text = ourpath + naming.TypeNameHere.Text + ".lesscore";
                if (!ExplorerTimer.Enabled)
                {
                    ExplorerTimer.Start();
                }
            }
        }

        public async void SaveProject_Click(object sender, EventArgs e)
        {
            SaveAll();

            string ContentOf = $"NameOfProject={ProjectName.Text}\n" +
                    "FileList=>" +
                    "{";

            foreach (var cntnt in ProjectExplorer.Content)
            {
                ContentOf += cntnt.Path + ",";
            }

            ContentOf += "}";

            File.WriteAllText(ProjectPath.Text, ContentOf);
        }

        void SaveAll()
        {
            foreach (TabPage tp in MainTabs.TabPages)
            {
                File.WriteAllText(tp.Name, tp.Controls[0].Text);
            }
        }

        private void SaveAll_Tool_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        public static async Task<string> ConvertLessToCSS(string path, string targetpath)
        {
            return await ElroubyCMD.Executer.RunCommand("lessc \"" + path + "\" \"" + targetpath + "\"");
        }

        private async void Publish_Click(object sender, EventArgs e)
        {
            if (ProjectName.Text.Length > 0 && ProjectPath.Text.Length > 0)
            {
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (FileInfo fi in new DirectoryInfo(ProjectPath.Text.Replace(ProjectPath.Text.Split('\\').Last(), "")).GetFiles())
                    {
                        if (fi.Extension == ".less")
                        {
                            await ConvertLessToCSS(fi.FullName, FolderBrowserDialog.SelectedPath + "\\" + fi.Name.Replace(".less", ".css"));
                        }
                        else if (fi.Extension == ".css")
                        {
                            var TargetPath = FolderBrowserDialog.SelectedPath + "\\" + fi.Name.Replace(".less", ".css");
                            if (File.Exists(TargetPath))
                                File.Delete(TargetPath);

                            File.Copy(fi.FullName, TargetPath);
                        }
                    }
                }
            }
            else MessageBox.Show("Project not found");
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenLessOrCssFile.ShowDialog() == DialogResult.OK)
            {
                if (ProjectName.Text.Length == 0)
                {
                    OpenFileVOID(OpenLessOrCssFile.FileName);
                }
                else
                {
                    File.Copy(OpenLessOrCssFile.FileName, RemoveLastFile(ProjectPath.Text) + $"\\" + OpenLessOrCssFile.FileName.Split('\\').Last());
                }
            }
        }

        string RemoveLastFile(string Path)
        {
            string SavePath = "";
            string[] Parts = Path.Split('\\');

            for (int i = 0; i < Parts.Count() - 1; i++)
            {
                SavePath += Parts[i] + "\\";
            }

            return SavePath;
        }
        private void ExplorerTimer_Tick(object sender, EventArgs e)
        {
            var FolderControl = new DirectoryInfo(RemoveLastFile(ProjectPath.Text));
            var Files = FolderControl.GetFiles().Where(x => x.Extension == ".less" || x.Extension == ".css");

            if (Files.Count() != ProjectExplorer.Content.Count())
            {
                ProjectExplorer.Content.Clear();

                foreach (FileInfo file in Files)
                {
                    if (file.Extension == ".css" || file.Extension == ".less")
                    {
                        var NEW = new FileWithNumber()
                        {
                            ID = 0,
                            Name = file.Name,
                            Path = file.FullName
                        };
                        ProjectExplorer.Content.Add(NEW);
                    }
                }


                SaveProject_Click(sender, e);
            }
        }

        private void NewFile_Tool_Click(object sender, EventArgs e)
        {
            NameYourProject nameit = new NameYourProject();
            nameit.ShowDialog();
            if (nameit.TypeNameHere.Text.Length == 0)
            {
                return;
            }

            if (nameit.TypeNameHere.Text.Last() == '.')
            {
                nameit.TypeNameHere.Text = nameit.TypeNameHere.Text.Remove(nameit.TypeNameHere.Text.Count() - 1);
            }

            nameit.TypeNameHere.Text += ".less";

            var SelectedPath = RemoveLastFile(ProjectPath.Text) + "\\" + nameit.TypeNameHere.Text;

            File.WriteAllText(SelectedPath, "Type your code here");

            OpenFileVOID(SelectedPath);
        }

        private void TabCntxt_Close_Click(object sender, EventArgs e)
        {
            if (MainTabs.SelectedTab != null)
                MainTabs.TabPages.Remove(MainTabs.SelectedTab);
        }

        private void TabCntxt_CloseallBut_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in MainTabs.TabPages)
            {
                if (tp != MainTabs.SelectedTab)
                {
                    MainTabs.TabPages.Remove(tp);
                }
            }
        }

        private void TabCntxt_Closeall_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in MainTabs.TabPages)
            {
                MainTabs.TabPages.Remove(tp);
            }
        }

        private void Clone_Click(object sender, EventArgs e)
        {
            NameYourProject nameit = new NameYourProject();
            nameit.ShowDialog();
            if (nameit.TypeNameHere.Text.Length == 0)
            {
                return;
            }

            if (nameit.TypeNameHere.Text.Last() == '.')
            {
                nameit.TypeNameHere.Text = nameit.TypeNameHere.Text.Remove(nameit.TypeNameHere.Text.Count() - 1);
            }

            nameit.TypeNameHere.Text += ".less";

            var SelectedPath = RemoveLastFile(ProjectPath.Text) + "\\" + nameit.TypeNameHere.Text;

            File.WriteAllText(SelectedPath, MainTabs.SelectedTab.Controls[0].Text);

            OpenFileVOID(SelectedPath);
        }

        private void SaveCurrent_Click(object sender, EventArgs e)
        {
            File.WriteAllText(MainTabs.SelectedTab.Name, MainTabs.SelectedTab.Controls[0].Text);
        }

        private void NewFile_Context_Click(object sender, EventArgs e)
        {
            NewFile_Tool_Click(sender, e);
        }

        private void ExistingFile_Context_Click(object sender, EventArgs e)
        {
            OpenFile_Click(sender, e);
        }

        private void RemoveSelected_Context_Click(object sender, EventArgs e)
        {
            foreach (FileWithNumber file in ProjectExplorer.Content)
            {
                if (ProjectExplorer.SelectedItem != null &&
                    file.Name == ProjectExplorer.SelectedItem.ToString())
                {
                    File.Delete(file.Path);

                    foreach (TabPage tp in MainTabs.TabPages)
                    {
                        if (tp.Name == file.Path)
                        {
                            MainTabs.TabPages.Remove(tp);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void Cut_Tool_Click(object sender, EventArgs e)
        {
            if (MainTabs.TabPages.Count > 0)
            {
                (MainTabs.SelectedTab.Controls[0] as Scintilla).Cut();
            }
        }

        private void Copy_Tool_Click(object sender, EventArgs e)
        {
            if (MainTabs.TabPages.Count > 0)
            {
                (MainTabs.SelectedTab.Controls[0] as Scintilla).Copy();
            }
        }

        private void Past_Tool_Click(object sender, EventArgs e)
        {
            if (MainTabs.TabPages.Count > 0)
            {
                (MainTabs.SelectedTab.Controls[0] as Scintilla).Paste();
            }
        }

        private void ClearText_Click(object sender, EventArgs e)
        {
            if (MainTabs.TabPages.Count > 0)
            {
                (MainTabs.SelectedTab.Controls[0] as Scintilla).ClearAll();
            }
        }

        private void Undo_Tool_Click(object sender, EventArgs e)
        {
            if (MainTabs.TabPages.Count > 0)
            {
                (MainTabs.SelectedTab.Controls[0] as Scintilla).Undo();
            }
        }

        private void RedoTool_Click(object sender, EventArgs e)
        {
            if (MainTabs.TabPages.Count > 0)
            {
                (MainTabs.SelectedTab.Controls[0] as Scintilla).Redo();
            }
        }

        private void MainTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            PublishTool.Enabled =
            SaveProject.Enabled =
            Test_Tool.Enabled = SaveFile_File.Enabled = Edit_Menu.Enabled = MainTabs.TabPages.Count > 0;
        }

        private void SaveFile_File_Click(object sender, EventArgs e)
        {
            File.WriteAllText(MainTabs.SelectedTab.Name, MainTabs.SelectedTab.Controls[0].Text);

            FileContent_Do(MainTabs.SelectedTab.Controls[0], e);
        }

        private void ApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SearchWindow SW;
        private void SearchWindow_Click(object sender, EventArgs e)
        {
            if (MainTabs.TabPages.Count > 0)
            {
                SW = new SearchWindow();
                SW.TopLevel = false;

                MainTabs.SelectedTab.Controls[0].Controls.Add(SW);
                SW.Show();
                SW.BringToFront();

                SW.Focus();
            }
        }

        ClassSelectPreview CSP;
        private void FreeHtml_Click(object sender, EventArgs e)
        {
            CSP = new ClassSelectPreview();

            Hide();

            CSP.editorcontainer.Controls.Add(MainTabs.SelectedTab.Controls[0]);
            (CSP.editorcontainer.Controls[0] as Scintilla).Dock = DockStyle.Fill;
            (CSP.editorcontainer.Controls[0] as Scintilla).TextChanged += CSP.HtmlWrite_TextChanged;

            CSP.ShowDialog();

            MainTabs.SelectedTab.Controls.Add(CSP.editorcontainer.Controls[0]);
            (MainTabs.SelectedTab.Controls[0] as Scintilla).Dock = DockStyle.Fill;
            (MainTabs.SelectedTab.Controls[0] as Scintilla).TextChanged -= CSP.HtmlWrite_TextChanged;

            Show();
        }

        private async void ConvertToCSS_Click(object sender, EventArgs e)
        {
            if (ProjectExplorer.SelectedIndex > -1 && ProjectExplorer.SelectedItem.ToString().Contains(".less"))
            {
                var MainPath = ProjectPath.Text.Replace(ProjectPath.Text.Split('\\').Last(), "");
                await ConvertLessToCSS(MainPath + "\\" + ProjectExplorer.SelectedItem.ToString(),
                    MainPath + "\\" + ProjectExplorer.SelectedItem.ToString().Replace(".less", ".css"));
            }
            else MessageBox.Show("Not a less file");
        }

        private async void LessToCSSOpened_Click(object sender, EventArgs e)
        {
            if (MainTabs.SelectedTab != null && MainTabs.SelectedTab.Text.Replace("*", "").Contains(".css"))
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await ConvertLessToCSS(MainTabs.SelectedTab.Name, SaveFileDialog.FileName);
                }
            }
            else MessageBox.Show("Not a valid file to convert");
        }

        private void Generate_Loop_Click(object sender, EventArgs e)
        {
            new GenerateLoop().ShowDialog();
        }
    }
}
