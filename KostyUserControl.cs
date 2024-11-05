using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gambling
{
    public partial class KostyUserControl : UserControl
    {
        public MainForm mainForm;

        private bool isSpin = false;
        private bool mode = false; //false - more; true - less
        private int dice1Value, dice2Value;
        private string[] videoPath = new string[6];
        Random random = new Random();

        public KostyUserControl(Size size, MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            Size = size;
            Load();
        }

        private void Load()
        {
            dice1.Location = new Point((int)(Width / 2.137), (int)(Height / 2.471));
            dice1.Size = new Size((int)(Width / 9), (int)(Width / 9));

            dice2.Location = new Point((int)(Width / 1.345), (int)(Height / 2.471));
            dice2.Size = new Size((int)(Width / 9), (int)(Width / 9));

            int x = (int)(Width / 21.517),
                w = (int)(Width / 4.244);

            moreButton.Location = new Point(x,(int)(Height/9.75));
            moreButton.Size = new Size(w, (int)(Height / 8.56));
            lessButton.Location = new Point(x, (int)(Height / 3.989));
            lessButton.Size = moreButton.Size;
            sumPicture.Location = new Point(x, (int)(Height / 2.6));
            sumPicture.Size = new Size(w, (int)(w / 6.75));
            sumInputBack.Location = new Point(x, (int)(Height / 2.153));
            sumInputBack.Size = new Size(w, (int)(w / 5));

            minusButton.Location = new Point((int)(Width / 14.857), (int)(Height / 2.15));
            minusButton.Size = new Size((int)(sumInputBack.Height/1.5), (int)(sumInputBack.Height/1.02));
            plusButton.Location = new Point((int)(Width / 4.37), (int)(Height / 2.15));
            plusButton.Size = new Size((int)(sumInputBack.Height/1.5), (int)(sumInputBack.Height/1.02));
            minusButton.Font = new Font("Days One", (int)(minusButton.Height/2));
            plusButton.Font = new Font("Days One", (int)(minusButton.Height/2));

            sumLabel.Location = new Point((int)(Width/10.157), (int)(Height / 2.15));
            sumLabel.Size = new Size((int)(Width/7.68),(int)(sumInputBack.Height / 1.02));
            sumLabel.Font = new Font("Days One", (int)(minusButton.Height / 2));

            stavkaPicture.Location = new Point(x, (int)(Height / 1.782));
            stavkaPicture.Size = sumPicture.Size;
            stavkaInputBack.Location = new Point(x, (int)(Height / 1.56));
            stavkaInputBack.Size = sumInputBack.Size;
            playButton.Location = new Point(x, (int)(Height / 1.281));
            playButton.Size = moreButton.Size;


            sumLabel.BackColor = ColorTranslator.FromHtml("#e3e3e3");
            plusButton.BackColor = ColorTranslator.FromHtml("#e3e3e3");
            minusButton.BackColor = ColorTranslator.FromHtml("#e3e3e3");
        }


        private void moreButton_MouseClick(object sender, MouseEventArgs e)
        {
            mode = false;
            moreButton.Image = Properties.Resources.bilshe_green;
            lessButton.Image = Properties.Resources.menshe;
        }

        private void lessButton_MouseClick(object sender, MouseEventArgs e)
        {
            mode = true;
            lessButton.Image = Properties.Resources.menshe_green;
            moreButton.Image = Properties.Resources.bilshe;
        }

        private void playButton_MouseClick(object sender, MouseEventArgs e)
        {
            dice1Value = random.Next(0, 5);
            dice2Value = random.Next(0, 5);

        }


        private void moreButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode)
                moreButton.Image = Properties.Resources.bilshe_clicked;
        }
        private void moreButton_MouseEnter(object sender, EventArgs e)
        {
            if (mode)
                moreButton.Image = Properties.Resources.bilshe_hovered;
        }
        private void moreButton_MouseLeave(object sender, EventArgs e)
        {
            if (mode)
                moreButton.Image = Properties.Resources.bilshe;
        }
        private void moreButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (mode)
                moreButton.Image = Properties.Resources.bilshe;
        }
        private void lessButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!mode)
                lessButton.Image = Properties.Resources.menshe_clicked;
        }
        private void lessButton_MouseEnter(object sender, EventArgs e)
        {
            if (!mode)
                lessButton.Image = Properties.Resources.menshe_hovered;
        }
        private void lessButton_MouseLeave(object sender, EventArgs e)
        {
            if (!mode)
                lessButton.Image = Properties.Resources.menshe;
        }
        private void lessButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!mode)
                lessButton.Image = Properties.Resources.menshe;
        }
        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isSpin)
                playButton.Image = Properties.Resources.kinuti_clicked;
        }
        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            if (!isSpin)
                playButton.Image = Properties.Resources.kinuti_hovered;
        }
        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isSpin)
                playButton.Image = Properties.Resources.kinuti;
        }
        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isSpin)
                playButton.Image = Properties.Resources.kinuti;
        }
        private void plusButton_MouseClick(object sender, MouseEventArgs e)
        {
            plusButton.ForeColor = Color.Gray;
        }
        private void plusButton_MouseDown(object sender, MouseEventArgs e)
        {
            plusButton.ForeColor = Color.LightGray;
        }
        private void plusButton_MouseEnter(object sender, EventArgs e)
        {
            plusButton.ForeColor = Color.Gray;
        }
        private void plusButton_MouseLeave(object sender, EventArgs e)
        {
            plusButton.ForeColor = Color.Black;
        }
        private void plusButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (plusButton.ForeColor != Color.Gray)
                plusButton.ForeColor = Color.Black;
        }
        private void minusButton_MouseClick(object sender, MouseEventArgs e)
        {
            minusButton.ForeColor = Color.Gray;
        }
        private void minusButton_MouseDown(object sender, MouseEventArgs e)
        {
            minusButton.ForeColor = Color.LightGray;
        }
        private void minusButton_MouseEnter(object sender, EventArgs e)
        {
            minusButton.ForeColor = Color.Gray;
        }
        private void minusButton_MouseLeave(object sender, EventArgs e)
        {
            minusButton.ForeColor = Color.Black;
        }
        private void minusButton_MouseUp(object sender, MouseEventArgs e)
        {
            if(minusButton.ForeColor != Color.Gray)
                minusButton.ForeColor = Color.Black;
        }

        private void UserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                playButton_MouseClick(null, null);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                mainForm.backButton_MouseClick(null, null);
            }
        }
    }
}
