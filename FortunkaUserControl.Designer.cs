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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)krutytyButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wheel).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 40);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // FortunkaUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_roulette;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(wheel);
            Controls.Add(krutytyButton);
            DoubleBuffered = true;
            Name = "FortunkaUserControl";
            Size = new Size(1144, 594);
            ((System.ComponentModel.ISupportInitialize)krutytyButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)wheel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox krutytyButton;
        private PictureBox wheel;
        private Label label1;
        private Label label2;
    }
}
