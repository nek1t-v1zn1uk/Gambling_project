namespace Gambling
{
    partial class KostyUserControl
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
            moreButton = new PictureBox();
            lessButton = new PictureBox();
            playButton = new PictureBox();
            dice1 = new PictureBox();
            dice2 = new PictureBox();
            sumLabel = new Label();
            sumInputBack = new PictureBox();
            minusButton = new Label();
            plusButton = new Label();
            sumPicture = new PictureBox();
            stavkaPicture = new PictureBox();
            stavkaInputBack = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)moreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lessButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dice1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dice2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sumInputBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sumPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stavkaPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stavkaInputBack).BeginInit();
            SuspendLayout();
            // 
            // moreButton
            // 
            moreButton.BackColor = Color.Transparent;
            moreButton.Image = Properties.Resources.bilshe_green;
            moreButton.Location = new Point(33, 72);
            moreButton.Name = "moreButton";
            moreButton.Size = new Size(270, 75);
            moreButton.SizeMode = PictureBoxSizeMode.StretchImage;
            moreButton.TabIndex = 2;
            moreButton.TabStop = false;
            moreButton.MouseClick += moreButton_MouseClick;
            moreButton.MouseDown += moreButton_MouseDown;
            moreButton.MouseEnter += moreButton_MouseEnter;
            moreButton.MouseLeave += moreButton_MouseLeave;
            moreButton.MouseUp += moreButton_MouseUp;
            // 
            // lessButton
            // 
            lessButton.BackColor = Color.Transparent;
            lessButton.Image = Properties.Resources.menshe;
            lessButton.Location = new Point(33, 163);
            lessButton.Name = "lessButton";
            lessButton.Size = new Size(270, 75);
            lessButton.SizeMode = PictureBoxSizeMode.StretchImage;
            lessButton.TabIndex = 3;
            lessButton.TabStop = false;
            lessButton.MouseClick += lessButton_MouseClick;
            lessButton.MouseDown += lessButton_MouseDown;
            lessButton.MouseEnter += lessButton_MouseEnter;
            lessButton.MouseLeave += lessButton_MouseLeave;
            lessButton.MouseUp += lessButton_MouseUp;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Transparent;
            playButton.Image = Properties.Resources.kinuti;
            playButton.Location = new Point(33, 485);
            playButton.Name = "playButton";
            playButton.Size = new Size(270, 75);
            playButton.SizeMode = PictureBoxSizeMode.StretchImage;
            playButton.TabIndex = 4;
            playButton.TabStop = false;
            playButton.MouseClick += playButton_MouseClick;
            playButton.MouseDown += playButton_MouseDown;
            playButton.MouseEnter += playButton_MouseEnter;
            playButton.MouseLeave += playButton_MouseLeave;
            playButton.MouseUp += playButton_MouseUp;
            // 
            // dice1
            // 
            dice1.BackColor = Color.Transparent;
            dice1.Image = Properties.Resources.dice_6;
            dice1.Location = new Point(518, 232);
            dice1.Name = "dice1";
            dice1.Size = new Size(110, 127);
            dice1.SizeMode = PictureBoxSizeMode.StretchImage;
            dice1.TabIndex = 5;
            dice1.TabStop = false;
            // 
            // dice2
            // 
            dice2.BackColor = Color.Transparent;
            dice2.Image = Properties.Resources.dice_6;
            dice2.Location = new Point(725, 232);
            dice2.Name = "dice2";
            dice2.Size = new Size(110, 127);
            dice2.SizeMode = PictureBoxSizeMode.StretchImage;
            dice2.TabIndex = 6;
            dice2.TabStop = false;
            // 
            // sumLabel
            // 
            sumLabel.BackColor = Color.White;
            sumLabel.Font = new Font("Days One", 64.2000046F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sumLabel.Location = new Point(86, 282);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(146, 140);
            sumLabel.TabIndex = 7;
            sumLabel.Text = "7";
            sumLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sumInputBack
            // 
            sumInputBack.BackColor = Color.Transparent;
            sumInputBack.Image = Properties.Resources.input_back;
            sumInputBack.Location = new Point(33, 285);
            sumInputBack.Name = "sumInputBack";
            sumInputBack.Size = new Size(270, 54);
            sumInputBack.SizeMode = PictureBoxSizeMode.StretchImage;
            sumInputBack.TabIndex = 8;
            sumInputBack.TabStop = false;
            // 
            // minusButton
            // 
            minusButton.Font = new Font("Days One", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            minusButton.ForeColor = Color.Black;
            minusButton.Location = new Point(44, 282);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(45, 45);
            minusButton.TabIndex = 9;
            minusButton.Text = "<";
            minusButton.TextAlign = ContentAlignment.MiddleCenter;
            minusButton.MouseClick += minusButton_MouseClick;
            minusButton.MouseDown += minusButton_MouseDown;
            minusButton.MouseEnter += minusButton_MouseEnter;
            minusButton.MouseLeave += minusButton_MouseLeave;
            minusButton.MouseUp += minusButton_MouseUp;
            // 
            // plusButton
            // 
            plusButton.Font = new Font("Days One", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            plusButton.ForeColor = Color.Black;
            plusButton.Location = new Point(236, 282);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(45, 45);
            plusButton.TabIndex = 10;
            plusButton.Text = ">";
            plusButton.TextAlign = ContentAlignment.MiddleCenter;
            plusButton.MouseClick += plusButton_MouseClick;
            plusButton.MouseDown += plusButton_MouseDown;
            plusButton.MouseEnter += plusButton_MouseEnter;
            plusButton.MouseLeave += plusButton_MouseLeave;
            plusButton.MouseUp += plusButton_MouseUp;
            // 
            // sumPicture
            // 
            sumPicture.BackColor = Color.Transparent;
            sumPicture.Image = Properties.Resources.suma;
            sumPicture.Location = new Point(33, 239);
            sumPicture.Name = "sumPicture";
            sumPicture.Size = new Size(270, 40);
            sumPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            sumPicture.TabIndex = 11;
            sumPicture.TabStop = false;
            // 
            // stavkaPicture
            // 
            stavkaPicture.BackColor = Color.Transparent;
            stavkaPicture.Image = Properties.Resources.stavka;
            stavkaPicture.Location = new Point(33, 423);
            stavkaPicture.Name = "stavkaPicture";
            stavkaPicture.Size = new Size(270, 40);
            stavkaPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            stavkaPicture.TabIndex = 12;
            stavkaPicture.TabStop = false;
            // 
            // stavkaInputBack
            // 
            stavkaInputBack.BackColor = Color.Transparent;
            stavkaInputBack.Image = Properties.Resources.input_back;
            stavkaInputBack.Location = new Point(33, 469);
            stavkaInputBack.Name = "stavkaInputBack";
            stavkaInputBack.Size = new Size(270, 54);
            stavkaInputBack.SizeMode = PictureBoxSizeMode.StretchImage;
            stavkaInputBack.TabIndex = 13;
            stavkaInputBack.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 14;
            // 
            // KostyUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_kosti;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(stavkaInputBack);
            Controls.Add(stavkaPicture);
            Controls.Add(sumPicture);
            Controls.Add(plusButton);
            Controls.Add(minusButton);
            Controls.Add(sumLabel);
            Controls.Add(dice2);
            Controls.Add(dice1);
            Controls.Add(playButton);
            Controls.Add(lessButton);
            Controls.Add(moreButton);
            Controls.Add(sumInputBack);
            DoubleBuffered = true;
            Name = "KostyUserControl";
            Size = new Size(1034, 612);
            KeyPress += UserControl_KeyPress;
            ((System.ComponentModel.ISupportInitialize)moreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)lessButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)playButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dice1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dice2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sumInputBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)sumPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)stavkaPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)stavkaInputBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox moreButton;
        private PictureBox lessButton;
        private PictureBox playButton;
        private PictureBox dice1;
        private PictureBox dice2;
        private Label sumLabel;
        private PictureBox sumInputBack;
        private Label minusButton;
        private Label plusButton;
        private PictureBox sumPicture;
        private PictureBox stavkaPicture;
        private PictureBox stavkaInputBack;
        private Label label1;
    }
}
