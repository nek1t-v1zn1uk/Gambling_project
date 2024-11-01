namespace Gambling
{
    partial class MenuUserControl
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
            kostyButton = new PictureBox();
            ruletkaButton = new PictureBox();
            slotyButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)kostyButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ruletkaButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slotyButton).BeginInit();
            SuspendLayout();
            // 
            // kostyButton
            // 
            kostyButton.Anchor = AnchorStyles.None;
            kostyButton.BackColor = Color.Transparent;
            kostyButton.Image = Properties.Resources.kostya;
            kostyButton.Location = new Point(406, 388);
            kostyButton.Name = "kostyButton";
            kostyButton.Size = new Size(300, 113);
            kostyButton.SizeMode = PictureBoxSizeMode.Zoom;
            kostyButton.TabIndex = 5;
            kostyButton.TabStop = false;
            kostyButton.MouseClick += kostyButton_MouseClick;
            kostyButton.MouseDown += kostyButton_MouseDown;
            kostyButton.MouseEnter += kostyButton_MouseEnter;
            kostyButton.MouseLeave += kostyButton_MouseLeave;
            kostyButton.MouseUp += kostyButton_MouseUp;
            // 
            // ruletkaButton
            // 
            ruletkaButton.Anchor = AnchorStyles.None;
            ruletkaButton.BackColor = Color.Transparent;
            ruletkaButton.Image = Properties.Resources.ruletka;
            ruletkaButton.Location = new Point(406, 269);
            ruletkaButton.Name = "ruletkaButton";
            ruletkaButton.Size = new Size(300, 113);
            ruletkaButton.SizeMode = PictureBoxSizeMode.Zoom;
            ruletkaButton.TabIndex = 4;
            ruletkaButton.TabStop = false;
            ruletkaButton.MouseClick += ruletkaButton_MouseClick;
            ruletkaButton.MouseDown += ruletkaButton_MouseDown;
            ruletkaButton.MouseEnter += ruletkaButton_MouseEnter;
            ruletkaButton.MouseLeave += ruletkaButton_MouseLeave;
            ruletkaButton.MouseUp += ruletkaButton_MouseUp;
            // 
            // slotyButton
            // 
            slotyButton.Anchor = AnchorStyles.None;
            slotyButton.BackColor = Color.Transparent;
            slotyButton.Image = Properties.Resources.sloty;
            slotyButton.Location = new Point(406, 150);
            slotyButton.Name = "slotyButton";
            slotyButton.Size = new Size(300, 113);
            slotyButton.SizeMode = PictureBoxSizeMode.Zoom;
            slotyButton.TabIndex = 3;
            slotyButton.TabStop = false;
            slotyButton.MouseClick += slotyButton_MouseClick;
            slotyButton.MouseDown += slotyButton_MouseDown;
            slotyButton.MouseEnter += slotyButton_MouseEnter;
            slotyButton.MouseLeave += slotyButton_MouseLeave;
            slotyButton.MouseUp += slotyButton_MouseUp;
            // 
            // MenuUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(kostyButton);
            Controls.Add(ruletkaButton);
            Controls.Add(slotyButton);
            DoubleBuffered = true;
            Name = "MenuUserControl";
            Size = new Size(1113, 650);
            ((System.ComponentModel.ISupportInitialize)kostyButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ruletkaButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)slotyButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox kostyButton;
        private PictureBox ruletkaButton;
        private PictureBox slotyButton;
    }
}
