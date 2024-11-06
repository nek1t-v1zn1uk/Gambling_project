﻿namespace Gambling
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
            Result = new PictureBox();
            backButton = new PictureBox();
            zakrytyButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Result).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zakrytyButton).BeginInit();
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
            MainPanel.Controls.Add(Result);
            MainPanel.Location = new Point(447, 113);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(537, 318);
            MainPanel.TabIndex = 7;
            // 
            // Result
            // 
            Result.BackColor = Color.Transparent;
            Result.Image = Properties.Resources.Result;
            Result.Location = new Point(94, 93);
            Result.Name = "Result";
            Result.Size = new Size(348, 139);
            Result.SizeMode = PictureBoxSizeMode.StretchImage;
            Result.TabIndex = 0;
            Result.TabStop = false;
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
            // zakrytyButton
            // 
            zakrytyButton.BackColor = Color.Transparent;
            zakrytyButton.Image = Properties.Resources.zakrity_hovered;
            zakrytyButton.Location = new Point(646, 437);
            zakrytyButton.Name = "zakrytyButton";
            zakrytyButton.Size = new Size(200, 30);
            zakrytyButton.SizeMode = PictureBoxSizeMode.StretchImage;
            zakrytyButton.TabIndex = 1;
            zakrytyButton.TabStop = false;
            zakrytyButton.MouseClick += zakrytyButton_MouseClick;
            zakrytyButton.MouseDown += zakrytyButton_MouseDown;
            zakrytyButton.MouseEnter += zakrytyButton_MouseEnter;
            zakrytyButton.MouseLeave += zakrytyButton_MouseLeave;
            zakrytyButton.MouseUp += zakrytyButton_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 500);
            Controls.Add(backButton);
            Controls.Add(zakrytyButton);
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
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Result).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)zakrytyButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public PictureBox backButton;
        public Panel MainPanel;
        public PictureBox Result;
        public PictureBox zakrytyButton;
    }
}
