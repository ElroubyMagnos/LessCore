namespace ElroubyLessCore.Small_Windows
{
    partial class SearchWindow
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
            SearchWord = new TextBox();
            ReplaceWord = new TextBox();
            SearchBtn = new Button();
            ReplaceBtn = new Button();
            SuspendLayout();
            // 
            // SearchWord
            // 
            SearchWord.Location = new Point(12, 12);
            SearchWord.Name = "SearchWord";
            SearchWord.PlaceholderText = "Search Word";
            SearchWord.Size = new Size(165, 23);
            SearchWord.TabIndex = 0;
            SearchWord.KeyDown += SearchWord_KeyDown;
            // 
            // ReplaceWord
            // 
            ReplaceWord.Location = new Point(12, 53);
            ReplaceWord.Name = "ReplaceWord";
            ReplaceWord.PlaceholderText = "Replace Word";
            ReplaceWord.Size = new Size(165, 23);
            ReplaceWord.TabIndex = 1;
            ReplaceWord.KeyDown += ReplaceWord_KeyDown;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(102, 88);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ReplaceBtn
            // 
            ReplaceBtn.Location = new Point(12, 88);
            ReplaceBtn.Name = "ReplaceBtn";
            ReplaceBtn.Size = new Size(75, 23);
            ReplaceBtn.TabIndex = 3;
            ReplaceBtn.Text = "Replace";
            ReplaceBtn.UseVisualStyleBackColor = true;
            ReplaceBtn.Click += ReplaceBtn_Click;
            // 
            // SearchWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 122);
            Controls.Add(ReplaceBtn);
            Controls.Add(SearchBtn);
            Controls.Add(ReplaceWord);
            Controls.Add(SearchWord);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SearchWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchWord;
        private TextBox ReplaceWord;
        private Button SearchBtn;
        private Button ReplaceBtn;
    }
}