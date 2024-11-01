namespace Gambling
{
    partial class MainUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitButton = new PictureBox();
            settingsButton = new PictureBox();
            rakhunokButton = new PictureBox();
            gamblingButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rakhunokButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamblingButton).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.None;
            exitButton.BackColor = Color.Transparent;
            exitButton.Image = Properties.Resources.vihid;
            exitButton.Location = new Point(444, 413);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(360, 100);
            exitButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitButton.TabIndex = 11;
            exitButton.TabStop = false;
            exitButton.MouseClick += exitButton_MouseClick;
            exitButton.MouseDown += exitButton_MouseDown;
            exitButton.MouseEnter += exitButton_MouseEnter;
            exitButton.MouseLeave += exitButton_MouseLeave;
            exitButton.MouseUp += exitButton_MouseUp;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.None;
            settingsButton.BackColor = Color.Transparent;
            settingsButton.Image = Properties.Resources.nalashtuvanya;
            settingsButton.Location = new Point(444, 312);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(360, 100);
            settingsButton.SizeMode = PictureBoxSizeMode.Zoom;
            settingsButton.TabIndex = 10;
            settingsButton.TabStop = false;
            settingsButton.MouseDown += settingsButton_MouseDown;
            settingsButton.MouseEnter += settingsButton_MouseEnter;
            settingsButton.MouseLeave += settingsButton_MouseLeave;
            settingsButton.MouseUp += settingsButton_MouseUp;
            // 
            // rakhunokButton
            // 
            rakhunokButton.Anchor = AnchorStyles.None;
            rakhunokButton.BackColor = Color.Transparent;
            rakhunokButton.Image = Properties.Resources.rahunok;
            rakhunokButton.Location = new Point(444, 212);
            rakhunokButton.Name = "rakhunokButton";
            rakhunokButton.Size = new Size(360, 100);
            rakhunokButton.SizeMode = PictureBoxSizeMode.Zoom;
            rakhunokButton.TabIndex = 9;
            rakhunokButton.TabStop = false;
            rakhunokButton.MouseDown += rakhunokButton_MouseDown;
            rakhunokButton.MouseEnter += rakhunokButton_MouseEnter;
            rakhunokButton.MouseLeave += rakhunokButton_MouseLeave;
            rakhunokButton.MouseUp += rakhunokButton_MouseUp;
            // 
            // gamblingButton
            // 
            gamblingButton.Anchor = AnchorStyles.None;
            gamblingButton.BackColor = Color.Transparent;
            gamblingButton.BackgroundImageLayout = ImageLayout.None;
            gamblingButton.Image = Properties.Resources.gambling;
            gamblingButton.Location = new Point(444, 112);
            gamblingButton.Name = "gamblingButton";
            gamblingButton.Size = new Size(360, 100);
            gamblingButton.SizeMode = PictureBoxSizeMode.Zoom;
            gamblingButton.TabIndex = 7;
            gamblingButton.TabStop = false;
            gamblingButton.MouseClick += gamblingButton_MouseClick;
            gamblingButton.MouseDown += gamblingButton_MouseDown;
            gamblingButton.MouseEnter += gamblingButton_MouseEnter;
            gamblingButton.MouseLeave += gamblingButton_MouseLeave;
            gamblingButton.MouseUp += gamblingButton_MouseUp;
            // 
            // MainUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(exitButton);
            Controls.Add(settingsButton);
            Controls.Add(rakhunokButton);
            Controls.Add(gamblingButton);
            DoubleBuffered = true;
            Name = "MainUserControl";
            Size = new Size(1250, 622);
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)rakhunokButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamblingButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox exitButton;
        private PictureBox settingsButton;
        private PictureBox rakhunokButton;
        private PictureBox gamblingButton;
    }
}
