namespace ElroubyLessCore
{
    partial class GenerateLoop
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
            components = new System.ComponentModel.Container();
            LoopName = new TextBox();
            LoopPreview = new ScintillaNET.Scintilla();
            LoopCount = new DesktopSupport.IntegerBox();
            label1 = new Label();
            PropertyName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PropertyValue = new TextBox();
            ToCSS = new DesktopSupport.SkyButton();
            CSSContainer = new ScintillaNET.Scintilla();
            EntryToLoop = new DesktopSupport.SkyButton();
            label4 = new Label();
            Increment = new TextBox();
            TimerForConvert = new System.Windows.Forms.Timer(components);
            CopyCSS = new DesktopSupport.SkyButton();
            CopyLoop = new DesktopSupport.SkyButton();
            SuspendLayout();
            // 
            // LoopName
            // 
            LoopName.Location = new Point(12, 12);
            LoopName.Name = "LoopName";
            LoopName.PlaceholderText = "Loop Name";
            LoopName.Size = new Size(225, 23);
            LoopName.TabIndex = 0;
            // 
            // LoopPreview
            // 
            LoopPreview.AutoCMaxHeight = 9;
            LoopPreview.Lexer = ScintillaNET.Lexer.Css;
            LoopPreview.Location = new Point(309, 12);
            LoopPreview.Name = "LoopPreview";
            LoopPreview.Size = new Size(328, 219);
            LoopPreview.TabIndex = 5;
            // 
            // LoopCount
            // 
            LoopCount.Location = new Point(105, 48);
            LoopCount.Name = "LoopCount";
            LoopCount.Size = new Size(132, 23);
            LoopCount.TabIndex = 1;
            LoopCount.Text = "0";
            LoopCount.Value = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Loop Count";
            // 
            // PropertyName
            // 
            PropertyName.Location = new Point(105, 77);
            PropertyName.Name = "PropertyName";
            PropertyName.Size = new Size(132, 23);
            PropertyName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Property Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 7;
            label3.Text = "Property Value";
            // 
            // PropertyValue
            // 
            PropertyValue.Location = new Point(105, 106);
            PropertyValue.Name = "PropertyValue";
            PropertyValue.Size = new Size(132, 23);
            PropertyValue.TabIndex = 3;
            // 
            // ToCSS
            // 
            ToCSS.BackColor = SystemColors.Control;
            ToCSS.BackgroundImage = Properties.Resources.downarrow;
            ToCSS.BackgroundImageLayout = ImageLayout.Stretch;
            ToCSS.DefaultColor = SystemColors.Highlight;
            ToCSS.FlatAppearance.BorderSize = 0;
            ToCSS.FlatStyle = FlatStyle.Flat;
            ToCSS.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToCSS.ForeColor = SystemColors.Control;
            ToCSS.Hover = Color.Empty;
            ToCSS.Location = new Point(91, 200);
            ToCSS.Name = "ToCSS";
            ToCSS.Size = new Size(32, 31);
            ToCSS.TabIndex = 8;
            ToCSS.UseVisualStyleBackColor = false;
            ToCSS.Click += ToCSS_Click;
            // 
            // CSSContainer
            // 
            CSSContainer.AutoCMaxHeight = 9;
            CSSContainer.Lexer = ScintillaNET.Lexer.Css;
            CSSContainer.Location = new Point(12, 237);
            CSSContainer.Name = "CSSContainer";
            CSSContainer.Size = new Size(625, 245);
            CSSContainer.TabIndex = 6;
            // 
            // EntryToLoop
            // 
            EntryToLoop.BackColor = SystemColors.Control;
            EntryToLoop.BackgroundImage = Properties.Resources.rightarrow;
            EntryToLoop.BackgroundImageLayout = ImageLayout.Stretch;
            EntryToLoop.DefaultColor = SystemColors.Highlight;
            EntryToLoop.FlatAppearance.BorderSize = 0;
            EntryToLoop.FlatStyle = FlatStyle.Flat;
            EntryToLoop.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EntryToLoop.ForeColor = SystemColors.Control;
            EntryToLoop.Hover = Color.Empty;
            EntryToLoop.Location = new Point(271, 80);
            EntryToLoop.Name = "EntryToLoop";
            EntryToLoop.Size = new Size(32, 31);
            EntryToLoop.TabIndex = 10;
            EntryToLoop.UseVisualStyleBackColor = false;
            EntryToLoop.Click += EntryToLoop_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 12;
            label4.Text = "Increment";
            // 
            // Increment
            // 
            Increment.Location = new Point(105, 135);
            Increment.Name = "Increment";
            Increment.Size = new Size(132, 23);
            Increment.TabIndex = 4;
            // 
            // TimerForConvert
            // 
            TimerForConvert.Enabled = true;
            TimerForConvert.Interval = 1000;
            TimerForConvert.Tick += TimerForConvert_Tick;
            // 
            // CopyCSS
            // 
            CopyCSS.BackColor = SystemColors.Control;
            CopyCSS.BackgroundImage = Properties.Resources.copy;
            CopyCSS.BackgroundImageLayout = ImageLayout.Stretch;
            CopyCSS.DefaultColor = SystemColors.Highlight;
            CopyCSS.FlatAppearance.BorderSize = 0;
            CopyCSS.FlatStyle = FlatStyle.Flat;
            CopyCSS.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CopyCSS.ForeColor = SystemColors.Control;
            CopyCSS.Hover = Color.Empty;
            CopyCSS.Location = new Point(129, 200);
            CopyCSS.Name = "CopyCSS";
            CopyCSS.Size = new Size(32, 31);
            CopyCSS.TabIndex = 13;
            CopyCSS.UseVisualStyleBackColor = false;
            CopyCSS.Click += CopyCSS_Click;
            // 
            // CopyLoop
            // 
            CopyLoop.BackColor = SystemColors.Control;
            CopyLoop.BackgroundImage = Properties.Resources.copy;
            CopyLoop.BackgroundImageLayout = ImageLayout.Stretch;
            CopyLoop.DefaultColor = SystemColors.Highlight;
            CopyLoop.FlatAppearance.BorderSize = 0;
            CopyLoop.FlatStyle = FlatStyle.Flat;
            CopyLoop.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CopyLoop.ForeColor = SystemColors.Control;
            CopyLoop.Hover = Color.Empty;
            CopyLoop.Location = new Point(271, 122);
            CopyLoop.Name = "CopyLoop";
            CopyLoop.Size = new Size(32, 31);
            CopyLoop.TabIndex = 14;
            CopyLoop.UseVisualStyleBackColor = false;
            CopyLoop.Click += CopyLoop_Click;
            // 
            // GenerateLoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 494);
            Controls.Add(CopyLoop);
            Controls.Add(CopyCSS);
            Controls.Add(label4);
            Controls.Add(Increment);
            Controls.Add(EntryToLoop);
            Controls.Add(CSSContainer);
            Controls.Add(ToCSS);
            Controls.Add(label3);
            Controls.Add(PropertyValue);
            Controls.Add(label2);
            Controls.Add(PropertyName);
            Controls.Add(label1);
            Controls.Add(LoopCount);
            Controls.Add(LoopPreview);
            Controls.Add(LoopName);
            Name = "GenerateLoop";
            Text = "GenerateLoop";
            Load += GenerateLoop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoopName;
        private ScintillaNET.Scintilla LoopPreview;
        private DesktopSupport.IntegerBox LoopCount;
        private Label label1;
        private TextBox PropertyName;
        private Label label2;
        private Label label3;
        private TextBox PropertyValue;
        private DesktopSupport.SkyButton ToCSS;
        private ScintillaNET.Scintilla CSSContainer;
        private DesktopSupport.SkyButton EntryToLoop;
        private Label label4;
        private TextBox Increment;
        private System.Windows.Forms.Timer TimerForConvert;
        private DesktopSupport.SkyButton CopyCSS;
        private DesktopSupport.SkyButton CopyLoop;
    }
}