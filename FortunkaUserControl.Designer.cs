namespace Gambling
{
    partial class FortunkaUserControl
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
            krutytyButton = new PictureBox();
            wheel = new PictureBox();
            stavkaInputBack = new PictureBox();
            stavkaPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)krutytyButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wheel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stavkaInputBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stavkaPicture).BeginInit();
            SuspendLayout();
            // 
            // krutytyButton
            // 
            krutytyButton.BackColor = Color.Transparent;
            krutytyButton.Image = Properties.Resources.krutity;
            krutytyButton.Location = new Point(367, 450);
            krutytyButton.Name = "krutytyButton";
            krutytyButton.Size = new Size(450, 125);
            krutytyButton.TabIndex = 0;
            krutytyButton.TabStop = false;
            krutytyButton.MouseClick += krutytyButton_MouseClick;
            krutytyButton.MouseDown += krutytyButton_MouseDown;
            krutytyButton.MouseEnter += krutytyButton_MouseEnter;
            krutytyButton.MouseLeave += krutytyButton_MouseLeave;
            krutytyButton.MouseUp += krutytyButton_MouseUp;
            // 
            // wheel
            // 
            wheel.BackColor = Color.Transparent;
            wheel.Image = Properties.Resources.wheel_of_fortune_inside;
            wheel.Location = new Point(381, 54);
            wheel.Name = "wheel";
            wheel.Size = new Size(365, 367);
            wheel.SizeMode = PictureBoxSizeMode.StretchImage;
            wheel.TabIndex = 1;
            wheel.TabStop = false;
            // 
            // stavkaInputBack
            // 
            stavkaInputBack.BackColor = Color.Transparent;
            stavkaInputBack.Image = Properties.Resources.input_back;
            stavkaInputBack.Location = new Point(842, 226);
            stavkaInputBack.Name = "stavkaInputBack";
            stavkaInputBack.Size = new Size(270, 54);
            stavkaInputBack.SizeMode = PictureBoxSizeMode.StretchImage;
            stavkaInputBack.TabIndex = 15;
            stavkaInputBack.TabStop = false;
            // 
            // stavkaPicture
            // 
            stavkaPicture.BackColor = Color.Transparent;
            stavkaPicture.Image = Properties.Resources.stavka;
            stavkaPicture.Location = new Point(842, 180);
            stavkaPicture.Name = "stavkaPicture";
            stavkaPicture.Size = new Size(270, 40);
            stavkaPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            stavkaPicture.TabIndex = 14;
            stavkaPicture.TabStop = false;
            // 
            // FortunkaUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_roulette;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(stavkaInputBack);
            Controls.Add(stavkaPicture);
            Controls.Add(wheel);
            Controls.Add(krutytyButton);
            DoubleBuffered = true;
            Name = "FortunkaUserControl";
            Size = new Size(1144, 594);
            KeyPress += UserControl_KeyPress;
            ((System.ComponentModel.ISupportInitialize)krutytyButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)wheel).EndInit();
            ((System.ComponentModel.ISupportInitialize)stavkaInputBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)stavkaPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox krutytyButton;
        private PictureBox wheel;
        private PictureBox stavkaInputBack;
        private PictureBox stavkaPicture;
    }
}
