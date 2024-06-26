﻿namespace ElroubyLessCore.Core
{
    partial class Loading
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
            PB = new ProgressBar();
            SuspendLayout();
            // 
            // PB
            // 
            PB.Dock = DockStyle.Fill;
            PB.Location = new Point(0, 0);
            PB.Name = "PB";
            PB.Size = new Size(412, 35);
            PB.TabIndex = 0;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 35);
            Controls.Add(PB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Loading";
            ResumeLayout(false);
        }

        #endregion

        public ProgressBar PB;
    }
}