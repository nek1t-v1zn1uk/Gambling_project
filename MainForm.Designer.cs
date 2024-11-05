namespace Gambling
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            MainPanel = new Panel();
            backButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(126, 382);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 3;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // MainPanel
            // 
            MainPanel.BackgroundImage = Properties.Resources.background_2;
            MainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MainPanel.Location = new Point(504, 193);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(250, 125);
            MainPanel.TabIndex = 7;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.Image = Properties.Resources.Back_button;
            backButton.Location = new Point(26, 21);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 75);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 8;
            backButton.TabStop = false;
            backButton.Visible = false;
            backButton.MouseClick += backButton_MouseClick;
            backButton.MouseDown += backButton_MouseDown;
            backButton.MouseEnter += backButton_MouseEnter;
            backButton.MouseLeave += backButton_MouseLeave;
            backButton.MouseUp += backButton_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 500);
            Controls.Add(backButton);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(MainPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(300, 500);
            Name = "MainForm";
            Text = "Gambling";
            WindowState = FormWindowState.Maximized;
            Shown += MainForm_Shown;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel MainPanel;
        public PictureBox backButton;
    }
}
