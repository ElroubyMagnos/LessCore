namespace ElroubyLessCore.Html_Windows
{
    partial class ClassSelectPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Preview = new CefSharp.WinForms.ChromiumWebBrowser();
            HtmlWrite = new ScintillaNET.Scintilla();
            editorcontainer = new Panel();
            SuspendLayout();
            // 
            // Preview
            // 
            Preview.ActivateBrowserOnCreation = false;
            Preview.Location = new Point(12, 197);
            Preview.Name = "Preview";
            Preview.Size = new Size(335, 197);
            Preview.TabIndex = 1;
            // 
            // HtmlWrite
            // 
            HtmlWrite.AutoCMaxHeight = 9;
            HtmlWrite.Location = new Point(12, 12);
            HtmlWrite.Name = "HtmlWrite";
            HtmlWrite.Size = new Size(335, 165);
            HtmlWrite.TabIndex = 2;
            HtmlWrite.TextChanged += HtmlWrite_TextChanged;
            HtmlWrite.KeyPress += HtmlWrite_KeyPress;
            HtmlWrite.KeyUp += HtmlWrite_KeyUp;
            // 
            // editorcontainer
            // 
            editorcontainer.Location = new Point(353, 12);
            editorcontainer.Name = "editorcontainer";
            editorcontainer.Size = new Size(267, 382);
            editorcontainer.TabIndex = 3;
            // 
            // ClassSelectPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 414);
            Controls.Add(editorcontainer);
            Controls.Add(HtmlWrite);
            Controls.Add(Preview);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClassSelectPreview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Html Preview";
            ResumeLayout(false);
        }

        #endregion
        private CefSharp.WinForms.ChromiumWebBrowser Preview;
        private ScintillaNET.Scintilla HtmlWrite;
        public Panel editorcontainer;
    }
}