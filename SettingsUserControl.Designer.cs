namespace Gambling
{
    partial class SettingsUserControl
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
            SomeText = new PictureBox();
            musicButton = new PictureBox();
            soundButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SomeText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)musicButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soundButton).BeginInit();
            SuspendLayout();
            // 
            // SomeText
            // 
            SomeText.BackColor = Color.Transparent;
            SomeText.Image = Properties.Resources.settings_buttons;
            SomeText.Location = new Point(404, 248);
            SomeText.Name = "SomeText";
            SomeText.Size = new Size(363, 169);
            SomeText.SizeMode = PictureBoxSizeMode.StretchImage;
            SomeText.TabIndex = 0;
            SomeText.TabStop = false;
            // 
            // musicButton
            // 
            musicButton.BackColor = Color.Transparent;
            musicButton.Image = Properties.Resources.sound;
            musicButton.Location = new Point(318, 248);
            musicButton.Name = "musicButton";
            musicButton.Size = new Size(100, 100);
            musicButton.SizeMode = PictureBoxSizeMode.StretchImage;
            musicButton.TabIndex = 1;
            musicButton.TabStop = false;
            musicButton.MouseClick += musicButton_MouseClick;
            // 
            // soundButton
            // 
            soundButton.BackColor = Color.Transparent;
            soundButton.Image = Properties.Resources.sound;
            soundButton.Location = new Point(318, 348);
            soundButton.Name = "soundButton";
            soundButton.Size = new Size(100, 100);
            soundButton.SizeMode = PictureBoxSizeMode.StretchImage;
            soundButton.TabIndex = 2;
            soundButton.TabStop = false;
            soundButton.MouseClick += soundButton_MouseClick;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(soundButton);
            Controls.Add(SomeText);
            Controls.Add(musicButton);
            DoubleBuffered = true;
            Name = "SettingsUserControl";
            Size = new Size(1021, 505);
            KeyPress += UserControl_KeyPress;
            ((System.ComponentModel.ISupportInitialize)SomeText).EndInit();
            ((System.ComponentModel.ISupportInitialize)musicButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)soundButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox SomeText;
        private PictureBox musicButton;
        private PictureBox soundButton;
    }
}
