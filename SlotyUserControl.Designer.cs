﻿namespace Gambling
{
    partial class SlotyUserControl
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
            sloty = new PictureBox();
            krutytyButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sloty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)krutytyButton).BeginInit();
            SuspendLayout();
            // 
            // sloty
            // 
            sloty.BackColor = Color.Transparent;
            sloty.Image = Properties.Resources.slots_bars_2;
            sloty.Location = new Point(224, 41);
            sloty.Name = "sloty";
            sloty.Size = new Size(674, 456);
            sloty.SizeMode = PictureBoxSizeMode.StretchImage;
            sloty.TabIndex = 0;
            sloty.TabStop = false;
            // 
            // krutytyButton
            // 
            krutytyButton.BackColor = Color.Transparent;
            krutytyButton.Image = Properties.Resources.krutity;
            krutytyButton.Location = new Point(326, 515);
            krutytyButton.Name = "krutytyButton";
            krutytyButton.Size = new Size(450, 125);
            krutytyButton.TabIndex = 1;
            krutytyButton.TabStop = false;
            krutytyButton.MouseClick += krutytyButton_MouseClick;
            krutytyButton.MouseDown += krutytyButton_MouseDown;
            krutytyButton.MouseEnter += krutytyButton_MouseEnter;
            krutytyButton.MouseLeave += krutytyButton_MouseLeave;
            krutytyButton.MouseUp += krutytyButton_MouseUp;
            // 
            // SlotyUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_slots;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(krutytyButton);
            Controls.Add(sloty);
            DoubleBuffered = true;
            Name = "SlotyUserControl";
            Size = new Size(1120, 656);
            ((System.ComponentModel.ISupportInitialize)sloty).EndInit();
            ((System.ComponentModel.ISupportInitialize)krutytyButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox sloty;
        private PictureBox krutytyButton;
    }
}