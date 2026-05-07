namespace Space_Invaders
{
    partial class SettingForm
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
            tbVolume = new TrackBar();
            VolumeLevel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbVolume).BeginInit();
            SuspendLayout();
            // 
            // tbVolume
            // 
            tbVolume.Location = new Point(301, 151);
            tbVolume.Maximum = 100;
            tbVolume.Name = "tbVolume";
            tbVolume.Size = new Size(125, 53);
            tbVolume.TabIndex = 0;
            tbVolume.Value = 50;
            tbVolume.Scroll += tbVolume_Scroll;
            // 
            // VolumeLevel
            // 
            VolumeLevel.AutoSize = true;
            VolumeLevel.ForeColor = Color.White;
            VolumeLevel.Location = new Point(344, 184);
            VolumeLevel.Name = "VolumeLevel";
            VolumeLevel.Size = new Size(44, 20);
            VolumeLevel.TabIndex = 1;
            VolumeLevel.Text = "50 %";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 151);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Volume Level";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(VolumeLevel);
            Controls.Add(tbVolume);
            Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "SettingForm";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)tbVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbVolume;
        private Label VolumeLevel;
        private Label label1;
    }
}