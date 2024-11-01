namespace Gambling
{
    partial class MenuForm
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
            slotyButton = new PictureBox();
            ruletkaButton = new PictureBox();
            kostyButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)slotyButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ruletkaButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kostyButton).BeginInit();
            SuspendLayout();
            // 
            // slotyButton
            // 
            slotyButton.Anchor = AnchorStyles.None;
            slotyButton.Image = Properties.Resources.sloty;
            slotyButton.Location = new Point(411, 183);
            slotyButton.Name = "slotyButton";
            slotyButton.Size = new Size(300, 113);
            slotyButton.SizeMode = PictureBoxSizeMode.Zoom;
            slotyButton.TabIndex = 0;
            slotyButton.TabStop = false;
            slotyButton.MouseDown += slotyButton_MouseDown;
            slotyButton.MouseEnter += slotyButton_MouseEnter;
            slotyButton.MouseLeave += slotyButton_MouseLeave;
            slotyButton.MouseUp += slotyButton_MouseUp;
            // 
            // ruletkaButton
            // 
            ruletkaButton.Anchor = AnchorStyles.None;
            ruletkaButton.Image = Properties.Resources.ruletka;
            ruletkaButton.Location = new Point(411, 302);
            ruletkaButton.Name = "ruletkaButton";
            ruletkaButton.Size = new Size(300, 113);
            ruletkaButton.SizeMode = PictureBoxSizeMode.Zoom;
            ruletkaButton.TabIndex = 1;
            ruletkaButton.TabStop = false;
            ruletkaButton.MouseDown += ruletkaButton_MouseDown;
            ruletkaButton.MouseEnter += ruletkaButton_MouseEnter;
            ruletkaButton.MouseLeave += ruletkaButton_MouseLeave;
            ruletkaButton.MouseUp += ruletkaButton_MouseUp;
            // 
            // kostyButton
            // 
            kostyButton.Anchor = AnchorStyles.None;
            kostyButton.Image = Properties.Resources.kostya;
            kostyButton.Location = new Point(411, 421);
            kostyButton.Name = "kostyButton";
            kostyButton.Size = new Size(300, 113);
            kostyButton.SizeMode = PictureBoxSizeMode.Zoom;
            kostyButton.TabIndex = 2;
            kostyButton.TabStop = false;
            kostyButton.MouseDown += kostyButton_MouseDown;
            kostyButton.MouseEnter += kostyButton_MouseEnter;
            kostyButton.MouseLeave += kostyButton_MouseLeave;
            kostyButton.MouseUp += kostyButton_MouseUp;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 565);
            Controls.Add(kostyButton);
            Controls.Add(ruletkaButton);
            Controls.Add(slotyButton);
            MinimumSize = new Size(300, 500);
            Name = "MenuForm";
            Text = "Gambling";
            Load += Form1_Load;
            SizeChanged += Form1_Resize;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)slotyButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ruletkaButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)kostyButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox slotyButton;
        private PictureBox ruletkaButton;
        private PictureBox kostyButton;

    }
}
