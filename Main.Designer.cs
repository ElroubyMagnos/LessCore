using ElroubyLessCore.Core;

namespace ElroubyLessCore
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            projectsToolStripMenuItem = new ToolStripMenuItem();
            OpenProject = new ToolStripMenuItem();
            SaveProject = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            NewProject = new ToolStripMenuItem();
            PublishTool = new ToolStripMenuItem();
            filesToolStripMenuItem = new ToolStripMenuItem();
            OpenFile = new ToolStripMenuItem();
            SaveFile_File = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            NewFile_Tool = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ApplicationExit = new ToolStripMenuItem();
            Edit_Menu = new ToolStripMenuItem();
            Cut_Tool = new ToolStripMenuItem();
            Copy_Tool = new ToolStripMenuItem();
            Past_Tool = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ClearText = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            Undo_Tool = new ToolStripMenuItem();
            RedoTool = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            SearchWindow = new ToolStripMenuItem();
            Test_Tool = new ToolStripMenuItem();
            hTMLToolStripMenuItem = new ToolStripMenuItem();
            FreeHtml = new ToolStripMenuItem();
            convertToolStripMenuItem = new ToolStripMenuItem();
            LessToCSSOpened = new ToolStripMenuItem();
            TabContext = new ContextMenuStrip(components);
            TabCntxt_Close = new ToolStripMenuItem();
            TabCntxt_CloseallBut = new ToolStripMenuItem();
            TabCntxt_Closeall = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            Clone = new ToolStripMenuItem();
            SaveCurrent = new ToolStripMenuItem();
            SaveAll_Tool = new ToolStripMenuItem();
            MainTabs = new TabControl();
            ProjectExplorer = new ClassListBox();
            SolutionContext = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            NewFile_Context = new ToolStripMenuItem();
            ExistingFile_Context = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            RemoveSelected_Context = new ToolStripMenuItem();
            lessToToolStripMenuItem = new ToolStripMenuItem();
            ConvertToCSS = new ToolStripMenuItem();
            OpenProjectDialog = new OpenFileDialog();
            NewProjectDialog = new FolderBrowserDialog();
            ProjectName = new TextBox();
            ProjectPath = new TextBox();
            OpenLessOrCssFile = new OpenFileDialog();
            ExplorerTimer = new System.Windows.Forms.Timer(components);
            SaveFileDialog = new SaveFileDialog();
            FolderBrowserDialog = new FolderBrowserDialog();
            GenerateLess_Menu = new ToolStripMenuItem();
            Generate_Loop = new ToolStripMenuItem();
            Menu.SuspendLayout();
            TabContext.SuspendLayout();
            SolutionContext.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, Edit_Menu, Test_Tool, convertToolStripMenuItem, GenerateLess_Menu });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(800, 24);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectsToolStripMenuItem, filesToolStripMenuItem, toolStripSeparator1, ApplicationExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // projectsToolStripMenuItem
            // 
            projectsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenProject, SaveProject, toolStripSeparator6, NewProject, PublishTool });
            projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            projectsToolStripMenuItem.Size = new Size(135, 22);
            projectsToolStripMenuItem.Text = "Projects";
            // 
            // OpenProject
            // 
            OpenProject.Name = "OpenProject";
            OpenProject.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            OpenProject.Size = new Size(178, 22);
            OpenProject.Text = "Open";
            OpenProject.Click += OpenProject_Click;
            // 
            // SaveProject
            // 
            SaveProject.Name = "SaveProject";
            SaveProject.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            SaveProject.Size = new Size(178, 22);
            SaveProject.Text = "Save";
            SaveProject.Click += SaveProject_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(175, 6);
            // 
            // NewProject
            // 
            NewProject.Name = "NewProject";
            NewProject.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            NewProject.Size = new Size(178, 22);
            NewProject.Text = "New";
            NewProject.Click += NewProject_Click;
            // 
            // PublishTool
            // 
            PublishTool.Name = "PublishTool";
            PublishTool.ShortcutKeys = Keys.Control | Keys.P;
            PublishTool.Size = new Size(178, 22);
            PublishTool.Text = "Publish";
            PublishTool.Click += Publish_Click;
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFile, SaveFile_File, toolStripSeparator7, NewFile_Tool });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(135, 22);
            filesToolStripMenuItem.Text = "Files";
            // 
            // OpenFile
            // 
            OpenFile.Name = "OpenFile";
            OpenFile.ShortcutKeys = Keys.Control | Keys.O;
            OpenFile.Size = new Size(202, 22);
            OpenFile.Text = "Open";
            OpenFile.Click += OpenFile_Click;
            // 
            // SaveFile_File
            // 
            SaveFile_File.Name = "SaveFile_File";
            SaveFile_File.ShortcutKeys = Keys.Control | Keys.S;
            SaveFile_File.Size = new Size(202, 22);
            SaveFile_File.Text = "Save Current File";
            SaveFile_File.Click += SaveFile_File_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(199, 6);
            // 
            // NewFile_Tool
            // 
            NewFile_Tool.Name = "NewFile_Tool";
            NewFile_Tool.ShortcutKeys = Keys.Control | Keys.N;
            NewFile_Tool.Size = new Size(202, 22);
            NewFile_Tool.Text = "New File";
            NewFile_Tool.Click += NewFile_Tool_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(132, 6);
            // 
            // ApplicationExit
            // 
            ApplicationExit.Name = "ApplicationExit";
            ApplicationExit.ShortcutKeys = Keys.Alt | Keys.F4;
            ApplicationExit.Size = new Size(135, 22);
            ApplicationExit.Text = "Exit";
            ApplicationExit.Click += ApplicationExit_Click;
            // 
            // Edit_Menu
            // 
            Edit_Menu.DropDownItems.AddRange(new ToolStripItem[] { Cut_Tool, Copy_Tool, Past_Tool, toolStripSeparator2, ClearText, toolStripSeparator5, Undo_Tool, RedoTool, toolStripSeparator8, SearchWindow });
            Edit_Menu.Name = "Edit_Menu";
            Edit_Menu.Size = new Size(39, 20);
            Edit_Menu.Text = "Edit";
            // 
            // Cut_Tool
            // 
            Cut_Tool.Name = "Cut_Tool";
            Cut_Tool.ShortcutKeys = Keys.Control | Keys.X;
            Cut_Tool.Size = new Size(198, 22);
            Cut_Tool.Text = "Cut";
            Cut_Tool.Click += Cut_Tool_Click;
            // 
            // Copy_Tool
            // 
            Copy_Tool.Name = "Copy_Tool";
            Copy_Tool.ShortcutKeys = Keys.Control | Keys.C;
            Copy_Tool.Size = new Size(198, 22);
            Copy_Tool.Text = "Copy";
            Copy_Tool.Click += Copy_Tool_Click;
            // 
            // Past_Tool
            // 
            Past_Tool.Name = "Past_Tool";
            Past_Tool.ShortcutKeys = Keys.Control | Keys.V;
            Past_Tool.Size = new Size(198, 22);
            Past_Tool.Text = "Paste";
            Past_Tool.Click += Past_Tool_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(195, 6);
            // 
            // ClearText
            // 
            ClearText.Name = "ClearText";
            ClearText.ShortcutKeys = Keys.Control | Keys.Shift | Keys.X;
            ClearText.Size = new Size(198, 22);
            ClearText.Text = "Clear Text";
            ClearText.Click += ClearText_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(195, 6);
            // 
            // Undo_Tool
            // 
            Undo_Tool.Name = "Undo_Tool";
            Undo_Tool.ShortcutKeys = Keys.Control | Keys.Z;
            Undo_Tool.Size = new Size(198, 22);
            Undo_Tool.Text = "Undo";
            Undo_Tool.Click += Undo_Tool_Click;
            // 
            // RedoTool
            // 
            RedoTool.Name = "RedoTool";
            RedoTool.ShortcutKeys = Keys.Control | Keys.Y;
            RedoTool.Size = new Size(198, 22);
            RedoTool.Text = "Redo";
            RedoTool.Click += RedoTool_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(195, 6);
            // 
            // SearchWindow
            // 
            SearchWindow.Name = "SearchWindow";
            SearchWindow.ShortcutKeys = Keys.Control | Keys.F;
            SearchWindow.Size = new Size(198, 22);
            SearchWindow.Text = "Search Window";
            SearchWindow.Click += SearchWindow_Click;
            // 
            // Test_Tool
            // 
            Test_Tool.DropDownItems.AddRange(new ToolStripItem[] { hTMLToolStripMenuItem });
            Test_Tool.Name = "Test_Tool";
            Test_Tool.Size = new Size(39, 20);
            Test_Tool.Text = "Test";
            // 
            // hTMLToolStripMenuItem
            // 
            hTMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FreeHtml });
            hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            hTMLToolStripMenuItem.Size = new Size(106, 22);
            hTMLToolStripMenuItem.Text = "HTML";
            // 
            // FreeHtml
            // 
            FreeHtml.Name = "FreeHtml";
            FreeHtml.Size = new Size(96, 22);
            FreeHtml.Text = "Free";
            FreeHtml.Click += FreeHtml_Click;
            // 
            // convertToolStripMenuItem
            // 
            convertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LessToCSSOpened });
            convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            convertToolStripMenuItem.Size = new Size(61, 20);
            convertToolStripMenuItem.Text = "Convert";
            // 
            // LessToCSSOpened
            // 
            LessToCSSOpened.Name = "LessToCSSOpened";
            LessToCSSOpened.Size = new Size(136, 22);
            LessToCSSOpened.Text = "LESS To CSS";
            LessToCSSOpened.Click += LessToCSSOpened_Click;
            // 
            // TabContext
            // 
            TabContext.Items.AddRange(new ToolStripItem[] { TabCntxt_Close, TabCntxt_CloseallBut, TabCntxt_Closeall, toolStripSeparator4, Clone, SaveCurrent, SaveAll_Tool });
            TabContext.Name = "contextMenuStrip1";
            TabContext.Size = new Size(169, 142);
            // 
            // TabCntxt_Close
            // 
            TabCntxt_Close.Name = "TabCntxt_Close";
            TabCntxt_Close.Size = new Size(168, 22);
            TabCntxt_Close.Text = "Close";
            TabCntxt_Close.Click += TabCntxt_Close_Click;
            // 
            // TabCntxt_CloseallBut
            // 
            TabCntxt_CloseallBut.Name = "TabCntxt_CloseallBut";
            TabCntxt_CloseallBut.Size = new Size(168, 22);
            TabCntxt_CloseallBut.Text = "Close All but THIS";
            TabCntxt_CloseallBut.Click += TabCntxt_CloseallBut_Click;
            // 
            // TabCntxt_Closeall
            // 
            TabCntxt_Closeall.Name = "TabCntxt_Closeall";
            TabCntxt_Closeall.Size = new Size(168, 22);
            TabCntxt_Closeall.Text = "Close All";
            TabCntxt_Closeall.Click += TabCntxt_Closeall_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(165, 6);
            // 
            // Clone
            // 
            Clone.Name = "Clone";
            Clone.Size = new Size(168, 22);
            Clone.Text = "Clone";
            Clone.Click += Clone_Click;
            // 
            // SaveCurrent
            // 
            SaveCurrent.Name = "SaveCurrent";
            SaveCurrent.Size = new Size(168, 22);
            SaveCurrent.Text = "Save";
            SaveCurrent.Click += SaveCurrent_Click;
            // 
            // SaveAll_Tool
            // 
            SaveAll_Tool.Name = "SaveAll_Tool";
            SaveAll_Tool.Size = new Size(168, 22);
            SaveAll_Tool.Text = "Save All";
            SaveAll_Tool.Click += SaveAll_Tool_Click;
            // 
            // MainTabs
            // 
            MainTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabs.ContextMenuStrip = TabContext;
            MainTabs.Location = new Point(134, 27);
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.Size = new Size(654, 411);
            MainTabs.TabIndex = 2;
            MainTabs.SelectedIndexChanged += MainTabs_SelectedIndexChanged;
            // 
            // ProjectExplorer
            // 
            ProjectExplorer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProjectExplorer.ContextMenuStrip = SolutionContext;
            ProjectExplorer.FormattingEnabled = true;
            ProjectExplorer.ItemHeight = 15;
            ProjectExplorer.Location = new Point(12, 87);
            ProjectExplorer.Name = "ProjectExplorer";
            ProjectExplorer.Size = new Size(109, 349);
            ProjectExplorer.TabIndex = 3;
            ProjectExplorer.SelectedIndexChanged += ProjectExplorer_SelectedIndexChanged;
            ProjectExplorer.DoubleClick += ProjectExplorer_DoubleClick;
            // 
            // SolutionContext
            // 
            SolutionContext.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, lessToToolStripMenuItem });
            SolutionContext.Name = "SolutionContext";
            SolutionContext.Size = new Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFile_Context, ExistingFile_Context });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(117, 22);
            addToolStripMenuItem.Text = "Add";
            // 
            // NewFile_Context
            // 
            NewFile_Context.Name = "NewFile_Context";
            NewFile_Context.Size = new Size(136, 22);
            NewFile_Context.Text = "New File";
            NewFile_Context.Click += NewFile_Context_Click;
            // 
            // ExistingFile_Context
            // 
            ExistingFile_Context.Name = "ExistingFile_Context";
            ExistingFile_Context.Size = new Size(136, 22);
            ExistingFile_Context.Text = "Existing File";
            ExistingFile_Context.Click += ExistingFile_Context_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RemoveSelected_Context });
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(117, 22);
            removeToolStripMenuItem.Text = "Remove";
            // 
            // RemoveSelected_Context
            // 
            RemoveSelected_Context.Name = "RemoveSelected_Context";
            RemoveSelected_Context.Size = new Size(118, 22);
            RemoveSelected_Context.Text = "Selected";
            RemoveSelected_Context.Click += RemoveSelected_Context_Click;
            // 
            // lessToToolStripMenuItem
            // 
            lessToToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConvertToCSS });
            lessToToolStripMenuItem.Name = "lessToToolStripMenuItem";
            lessToToolStripMenuItem.Size = new Size(117, 22);
            lessToToolStripMenuItem.Text = "Less To";
            // 
            // ConvertToCSS
            // 
            ConvertToCSS.Name = "ConvertToCSS";
            ConvertToCSS.Size = new Size(94, 22);
            ConvertToCSS.Text = "CSS";
            ConvertToCSS.Click += ConvertToCSS_Click;
            // 
            // OpenProjectDialog
            // 
            OpenProjectDialog.AddExtension = false;
            OpenProjectDialog.DefaultExt = "lesscore";
            OpenProjectDialog.Filter = "Less Project File|*.lesscore";
            // 
            // ProjectName
            // 
            ProjectName.Location = new Point(12, 27);
            ProjectName.Name = "ProjectName";
            ProjectName.PlaceholderText = "Project Name";
            ProjectName.ReadOnly = true;
            ProjectName.Size = new Size(109, 23);
            ProjectName.TabIndex = 4;
            // 
            // ProjectPath
            // 
            ProjectPath.Location = new Point(12, 56);
            ProjectPath.Name = "ProjectPath";
            ProjectPath.PlaceholderText = "Project Path";
            ProjectPath.ReadOnly = true;
            ProjectPath.Size = new Size(109, 23);
            ProjectPath.TabIndex = 5;
            // 
            // OpenLessOrCssFile
            // 
            OpenLessOrCssFile.DefaultExt = "less";
            OpenLessOrCssFile.Filter = "Less|*.less|Css|*.css";
            // 
            // ExplorerTimer
            // 
            ExplorerTimer.Interval = 1000;
            ExplorerTimer.Tick += ExplorerTimer_Tick;
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.DefaultExt = "css";
            SaveFileDialog.Filter = "CSS|*.css";
            // 
            // GenerateLess_Menu
            // 
            GenerateLess_Menu.DropDownItems.AddRange(new ToolStripItem[] { Generate_Loop });
            GenerateLess_Menu.Name = "GenerateLess_Menu";
            GenerateLess_Menu.Size = new Size(91, 20);
            GenerateLess_Menu.Text = "Generate Less";
            // 
            // Generate_Loop
            // 
            Generate_Loop.Name = "Generate_Loop";
            Generate_Loop.Size = new Size(180, 22);
            Generate_Loop.Text = "Loop";
            Generate_Loop.Click += Generate_Loop_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProjectPath);
            Controls.Add(ProjectName);
            Controls.Add(ProjectExplorer);
            Controls.Add(MainTabs);
            Controls.Add(Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Menu;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Less Core v1.0";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            TabContext.ResumeLayout(false);
            SolutionContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ContextMenuStrip TabContext;
        private TabControl MainTabs;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem OpenProject;
        private ToolStripMenuItem SaveProject;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem OpenFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ApplicationExit;
        private ToolStripMenuItem Edit_Menu;
        private ToolStripMenuItem Cut_Tool;
        private ToolStripMenuItem Copy_Tool;
        private ToolStripMenuItem Past_Tool;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ClearText;
        private ToolStripMenuItem Test_Tool;
        private ToolStripMenuItem hTMLToolStripMenuItem;
        private ToolStripMenuItem TabCntxt_Close;
        private ToolStripMenuItem TabCntxt_CloseallBut;
        private ToolStripMenuItem TabCntxt_Closeall;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem Clone;
        private ToolStripMenuItem SaveCurrent;
        private ClassListBox ProjectExplorer;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem Undo_Tool;
        private ToolStripMenuItem RedoTool;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem NewProject;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem NewFile_Tool;
        private ContextMenuStrip SolutionContext;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem NewFile_Context;
        private ToolStripMenuItem ExistingFile_Context;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem RemoveSelected_Context;
        private OpenFileDialog OpenProjectDialog;
        private ToolStripMenuItem PublishTool;
        private FolderBrowserDialog NewProjectDialog;
        private ToolStripMenuItem SaveAll_Tool;
        private TextBox ProjectName;
        private TextBox ProjectPath;
        private OpenFileDialog OpenLessOrCssFile;
        private System.Windows.Forms.Timer ExplorerTimer;
        private ToolStripMenuItem SaveFile_File;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem SearchWindow;
        private ToolStripMenuItem FreeHtml;
        private ToolStripMenuItem lessToToolStripMenuItem;
        private ToolStripMenuItem ConvertToCSS;
        private ToolStripMenuItem convertToolStripMenuItem;
        private ToolStripMenuItem LessToCSSOpened;
        private SaveFileDialog SaveFileDialog;
        private FolderBrowserDialog FolderBrowserDialog;
        private ToolStripMenuItem GenerateLess_Menu;
        private ToolStripMenuItem Generate_Loop;
    }
}
