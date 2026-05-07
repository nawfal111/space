namespace Space_Invaders
{
    partial class WelcomeForm
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
            LabelWelcome = new Label();
            bStart = new Button();
            label1 = new Label();
            bSettings = new Button();
            bExit = new Button();
            labelNickName = new Label();
            TimerName = new System.Windows.Forms.Timer(components);
            LabelName = new Label();
            tbName = new TextBox();
            bSave = new Button();
            SuspendLayout();
            // 
            // LabelWelcome
            // 
            LabelWelcome.AutoSize = true;
            LabelWelcome.Font = new Font("Consolas", 36.3130455F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWelcome.ForeColor = Color.White;
            LabelWelcome.Location = new Point(36, 9);
            LabelWelcome.Name = "LabelWelcome";
            LabelWelcome.Size = new Size(829, 68);
            LabelWelcome.TabIndex = 0;
            LabelWelcome.Text = "Welcome To Space Invaders";
            // 
            // bStart
            // 
            bStart.FlatStyle = FlatStyle.Flat;
            bStart.Font = new Font("Bahnschrift Condensed", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bStart.ForeColor = Color.White;
            bStart.Location = new Point(328, 258);
            bStart.Name = "bStart";
            bStart.Size = new Size(211, 42);
            bStart.TabIndex = 1;
            bStart.Text = "Start Game";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.139131F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(714, 610);
            label1.Name = "label1";
            label1.Size = new Size(171, 17);
            label1.TabIndex = 2;
            label1.Text = "Developed By Jad Al Armaly";
            // 
            // bSettings
            // 
            bSettings.FlatStyle = FlatStyle.Flat;
            bSettings.Font = new Font("Bahnschrift Condensed", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bSettings.ForeColor = Color.White;
            bSettings.Location = new Point(328, 306);
            bSettings.Name = "bSettings";
            bSettings.Size = new Size(211, 47);
            bSettings.TabIndex = 3;
            bSettings.Text = "Settings";
            bSettings.UseVisualStyleBackColor = true;
            bSettings.Click += bSettings_Click;
            // 
            // bExit
            // 
            bExit.FlatStyle = FlatStyle.Flat;
            bExit.Font = new Font("Bahnschrift Condensed", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bExit.ForeColor = Color.White;
            bExit.Location = new Point(328, 359);
            bExit.Name = "bExit";
            bExit.Size = new Size(211, 47);
            bExit.TabIndex = 4;
            bExit.Text = "Exit";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // labelNickName
            // 
            labelNickName.AutoSize = true;
            labelNickName.ForeColor = Color.White;
            labelNickName.Location = new Point(756, 442);
            labelNickName.Name = "labelNickName";
            labelNickName.Size = new Size(0, 20);
            labelNickName.TabIndex = 5;
            labelNickName.Click += label2_Click;
            // 
            // TimerName
            // 
            TimerName.Enabled = true;
            TimerName.Interval = 1000;
            TimerName.Tick += timer1_Tick;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.ForeColor = Color.White;
            LabelName.Location = new Point(238, 162);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(143, 20);
            LabelName.TabIndex = 6;
            LabelName.Text = "Type Your Nickname";
            // 
            // tbName
            // 
            tbName.BackColor = Color.Gray;
            tbName.Location = new Point(401, 162);
            tbName.Name = "tbName";
            tbName.Size = new Size(120, 26);
            tbName.TabIndex = 7;
            // 
            // bSave
            // 
            bSave.FlatStyle = FlatStyle.Flat;
            bSave.ForeColor = Color.White;
            bSave.Location = new Point(434, 194);
            bSave.Name = "bSave";
            bSave.Size = new Size(50, 28);
            bSave.TabIndex = 8;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(897, 636);
            Controls.Add(bSave);
            Controls.Add(tbName);
            Controls.Add(LabelName);
            Controls.Add(labelNickName);
            Controls.Add(bExit);
            Controls.Add(bSettings);
            Controls.Add(label1);
            Controls.Add(bStart);
            Controls.Add(LabelWelcome);
            ForeColor = Color.Black;
            Name = "WelcomeForm";
            Text = "Space Invaders";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelWelcome;
        private Button bStart;
        private Label label1;
        private Button bSettings;
        private Button bExit;
        private Label labelNickName;
        private System.Windows.Forms.Timer TimerName;
        private Label LabelName;
        private TextBox tbName;
        private Button bSave;
    }
}
