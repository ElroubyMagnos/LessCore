namespace ElroubyLessCore.Small_Windows
{
    partial class NameYourProject
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
            TypeNameHere = new TextBox();
            Enter = new Button();
            SuspendLayout();
            // 
            // TypeNameHere
            // 
            TypeNameHere.Location = new Point(12, 12);
            TypeNameHere.Name = "TypeNameHere";
            TypeNameHere.Size = new Size(130, 23);
            TypeNameHere.TabIndex = 0;
            TypeNameHere.KeyDown += TypeNameHere_KeyDown;
            // 
            // Enter
            // 
            Enter.Location = new Point(67, 41);
            Enter.Name = "Enter";
            Enter.Size = new Size(75, 23);
            Enter.TabIndex = 1;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // NameYourProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 90);
            Controls.Add(Enter);
            Controls.Add(TypeNameHere);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "NameYourProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Name your new";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Enter;
        public TextBox TypeNameHere;
    }
}