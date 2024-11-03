namespace Gambling
{
    partial class RakhunokUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pidtverdityButton = new PictureBox();
            pictureTextBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pidtverdityButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTextBox).BeginInit();
            SuspendLayout();
            // 
            // pidtverdityButton
            // 
            pidtverdityButton.BackColor = Color.Transparent;
            pidtverdityButton.Image = Properties.Resources.pidtverdity;
            pidtverdityButton.Location = new Point(247, 424);
            pidtverdityButton.Name = "pidtverdityButton";
            pidtverdityButton.Size = new Size(539, 168);
            pidtverdityButton.TabIndex = 1;
            pidtverdityButton.TabStop = false;
            pidtverdityButton.MouseClick += pidtverdityButton_MouseClick;
            pidtverdityButton.MouseDown += pidtverdityButton_MouseDown;
            pidtverdityButton.MouseEnter += pidtverdityButton_MouseEnter;
            pidtverdityButton.MouseLeave += pidtverdityButton_MouseLeave;
            pidtverdityButton.MouseUp += pidtverdityButton_MouseUp;
            // 
            // pictureTextBox
            // 
            pictureTextBox.BackColor = SystemColors.ActiveBorder;
            pictureTextBox.BackgroundImage = Properties.Resources.money_back;
            pictureTextBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureTextBox.Location = new Point(301, 254);
            pictureTextBox.Name = "pictureTextBox";
            pictureTextBox.Size = new Size(388, 56);
            pictureTextBox.TabIndex = 2;
            pictureTextBox.TabStop = false;
            // 
            // RakhunokUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureTextBox);
            Controls.Add(pidtverdityButton);
            DoubleBuffered = true;
            Name = "RakhunokUserControl";
            Size = new Size(971, 592);
            ((System.ComponentModel.ISupportInitialize)pidtverdityButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTextBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pidtverdityButton;
        private PictureBox pictureTextBox;
    }
}
