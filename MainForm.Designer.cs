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
            gamblingButton = new PictureBox();
            rakhunokButton = new PictureBox();
            settingsButton = new PictureBox();
            exitButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamblingButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rakhunokButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
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
            // 
            // gamblingButton
            // 
            gamblingButton.Anchor = AnchorStyles.None;
            gamblingButton.BackColor = Color.Transparent;
            gamblingButton.BackgroundImageLayout = ImageLayout.None;
            gamblingButton.BorderStyle = BorderStyle.FixedSingle;
            gamblingButton.Image = Properties.Resources.gambling;
            gamblingButton.Location = new Point(735, 260);
            gamblingButton.Name = "gamblingButton";
            gamblingButton.Size = new Size(450, 125);
            gamblingButton.SizeMode = PictureBoxSizeMode.Zoom;
            gamblingButton.TabIndex = 0;
            gamblingButton.TabStop = false;
            // 
            // rakhunokButton
            // 
            rakhunokButton.Anchor = AnchorStyles.None;
            rakhunokButton.BackColor = Color.Transparent;
            rakhunokButton.BorderStyle = BorderStyle.FixedSingle;
            rakhunokButton.Image = Properties.Resources.rahunok;
            rakhunokButton.Location = new Point(735, 420);
            rakhunokButton.Name = "rakhunokButton";
            rakhunokButton.Size = new Size(450, 125);
            rakhunokButton.SizeMode = PictureBoxSizeMode.Zoom;
            rakhunokButton.TabIndex = 4;
            rakhunokButton.TabStop = false;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.None;
            settingsButton.BackColor = Color.Transparent;
            settingsButton.BorderStyle = BorderStyle.FixedSingle;
            settingsButton.Image = Properties.Resources.nalashtuvanya;
            settingsButton.Location = new Point(735, 580);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(450, 125);
            settingsButton.SizeMode = PictureBoxSizeMode.Zoom;
            settingsButton.TabIndex = 5;
            settingsButton.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.None;
            exitButton.BackColor = Color.Transparent;
            exitButton.BorderStyle = BorderStyle.FixedSingle;
            exitButton.Image = Properties.Resources.vihid;
            exitButton.Location = new Point(735, 740);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(450, 125);
            exitButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitButton.TabIndex = 6;
            exitButton.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 565);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(exitButton);
            Controls.Add(settingsButton);
            Controls.Add(rakhunokButton);
            Controls.Add(gamblingButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(300, 500);
            Name = "MainForm";
            Text = "Gambling";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            SizeChanged += Form1_Resize;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamblingButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)rakhunokButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private PictureBox gamblingButton;
        private PictureBox rakhunokButton;
        private PictureBox settingsButton;
        private PictureBox exitButton;
    }
}
