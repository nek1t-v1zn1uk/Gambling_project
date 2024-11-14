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

        private TransparentTextBox transparentTextBox;

        private bool isSpin = false;
        private bool mode = false; //false - more; true - less
        private int dice1Value, dice2Value, sum = 7, sumValue, stavka;
        private string[] videoPath = new string[6];
        Random random = new Random();
        private bool canSpin = true;

        private static readonly double[,] coefficient = { 
            {0, 1.03}, //2
            {35, 1.09},
            {12, 1.3},
            {6, 1.4},
            {3.5, 1.6},
            {2.4, 2.4},
            {1.6, 3.5},
            {1.4, 6},
            {1.3, 12},
            {1.09, 35},
            {1.03, 0}  //12
        };

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

            moreButton.Location = new Point(x, (int)(Height / 9.75));
            moreButton.Size = new Size(w, (int)(Height / 8.56));
            lessButton.Location = new Point(x, (int)(Height / 3.989));
            lessButton.Size = moreButton.Size;
            sumPicture.Location = new Point(x, (int)(Height / 2.6));
            sumPicture.Size = new Size(w, (int)(w / 6.75));
            sumInputBack.Location = new Point(x, (int)(Height / 2.153));
            sumInputBack.Size = new Size(w, (int)(w / 5));

            minusButton.Location = new Point((int)(Width / 14.857), (int)(Height / 2.15));
            minusButton.Size = new Size((int)(sumInputBack.Height / 1.5), (int)(sumInputBack.Height / 1.02));
            plusButton.Location = new Point((int)(Width / 4.37), (int)(Height / 2.15));
            plusButton.Size = new Size((int)(sumInputBack.Height / 1.5), (int)(sumInputBack.Height / 1.02));
            minusButton.Font = new Font("Days One", (int)(minusButton.Height / 2));
            plusButton.Font = new Font("Days One", (int)(minusButton.Height / 2));

            sumLabel.Location = new Point((int)(Width / 10.157), (int)(Height / 2.15));
            sumLabel.Size = new Size((int)(Width / 7.68), (int)(sumInputBack.Height / 1.02));
            sumLabel.Font = new Font("Days One", (int)(minusButton.Height / 2));

            stavkaPicture.Location = new Point(x, (int)(Height / 1.782));
            stavkaPicture.Size = sumPicture.Size;
            stavkaInputBack.Location = new Point(x, (int)(Height / 1.56));
            stavkaInputBack.Size = sumInputBack.Size;
            playButton.Location = new Point(x, (int)(Height / 1.281));
            playButton.Size = moreButton.Size;

            AddTransparentTextBox();

            sumLabel.BackColor = ColorTranslator.FromHtml("#e3e3e3");
            plusButton.BackColor = ColorTranslator.FromHtml("#e3e3e3");
            minusButton.BackColor = ColorTranslator.FromHtml("#e3e3e3");
        }

        private void AddTransparentTextBox()
        {

            transparentTextBox = new TransparentTextBox
            {
                Text = "",

                ForeColor = Color.FromArgb(46, 46, 46),
                BackColor = ColorTranslator.FromHtml("#e3e3e3"),
                MaxLength = 7
            };

            transparentTextBox.Location = new Point((int)(stavkaInputBack.Location.X+(stavkaInputBack.Width / 12)), 
                stavkaInputBack.Location.Y + 2);
            transparentTextBox.Size = new Size((int)(stavkaInputBack.Width / 6 * 5), stavkaInputBack.Height);
            transparentTextBox.Font = new Font("Days One", (int)(transparentTextBox.Height*2));

            transparentTextBox.KeyPress += TransparentTextBox_KeyPress;
            transparentTextBox.Leave += (s, e) => CheckStavka();

            this.Controls.Add(transparentTextBox);
            transparentTextBox.BringToFront();
        }

        private void TransparentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            UserControl_KeyPress(sender, e);
        }

        private void CheckStavka()
        {
            if(transparentTextBox.Text != "" && int.Parse(transparentTextBox.Text) > mainForm.rakhunok)
            {
                transparentTextBox.Text = Math.Floor(mainForm.rakhunok).ToString();
            }
        }

        private async void spin()
        {
            dice1Value = random.Next(1, 7);
            dice2Value = random.Next(1, 7);
            Func<int, Image> getDiceGif = (v) =>
            {
                switch (v)
                {
                    case 1: return Properties.Resources.dices_1;
                    case 2: return Properties.Resources.dices_2;
                    case 3: return Properties.Resources.dices_3;
                    case 4: return Properties.Resources.dices_4;
                    case 5: return Properties.Resources.dices_5;
                    case 6: return Properties.Resources.dices_6;
                    default: return null;
                }
            };

            dice1.Image = getDiceGif(dice1Value);
            dice2.Image = getDiceGif(dice2Value);

            await Task.Delay(3500);

            if (canSpin == false)
                return;

            Func<int, Image> getDice = (v) =>
            {
                switch (v)
                {
                    case 1: return Properties.Resources.dice_1;
                    case 2: return Properties.Resources.dice_2;
                    case 3: return Properties.Resources.dice_3;
                    case 4: return Properties.Resources.dice_4;
                    case 5: return Properties.Resources.dice_5;
                    case 6: return Properties.Resources.dice_6;
                    default: return null;
                }
            };

            dice1.Image = getDice(dice1Value);
            dice2.Image = getDice(dice2Value);

            sumValue = dice1Value + dice2Value;

            if (sumValue > sum && !mode)
            {
                mainForm.ChangeRakhunok(coefficient[sum - 2, 1] * stavka);
                mainForm.ShowResult(coefficient[sum - 2, 1] * stavka);
            }
            else if (sumValue < sum && mode)
            {
                mainForm.ChangeRakhunok(coefficient[sum - 2, 0] * stavka);
                mainForm.ShowResult(coefficient[sum - 2, 0] * stavka);
            }
            isSpin = false;
            transparentTextBox.Enabled = true;
            playButton.Image = Properties.Resources.kinuti; 
            this.Focus();
        }

        public void Cancel()
        {
            canSpin = false;
        }
        private void moreButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isSpin && sum != 12)
            {
                mode = false;
                moreButton.Image = Properties.Resources.bilshe_green;
                lessButton.Image = Properties.Resources.menshe;
            }
        }
        private void lessButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isSpin && sum != 2)
            {
                mode = true;
                lessButton.Image = Properties.Resources.menshe_green;
                moreButton.Image = Properties.Resources.bilshe;
            }
        }

        private void playButton_MouseClick(object sender, MouseEventArgs e)
        {
            CheckStavka();
            if (!isSpin && transparentTextBox.Text != "" && int.Parse(transparentTextBox.Text)>0)
            {
                stavka = int.Parse(transparentTextBox.Text);
                mainForm.ChangeRakhunok(-stavka);
                isSpin = true;
                transparentTextBox.Enabled = false;
                this.Focus();
                spin();
                playButton.Image = Properties.Resources.kinuti_clicked;
            }
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
        public void plusButton_MouseClick(object sender, MouseEventArgs e)
        {
            plusButton.ForeColor = Color.Gray;
            if (!isSpin && sum < 12)
            {
                sum++;
                sumLabel.Text = sum.ToString();
                if (sum == 12)
                    lessButton_MouseClick(null, null);
            }
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
        public void minusButton_MouseClick(object sender, MouseEventArgs e)
        {
            minusButton.ForeColor = Color.Gray;
            if (!isSpin && sum > 2)
            {
                sum--;
                sumLabel.Text = sum.ToString();
                if (sum == 2)
                    moreButton_MouseClick(null, null);
            }
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
            if (minusButton.ForeColor != Color.Gray)
                minusButton.ForeColor = Color.Black;
        }

        private void UserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mainForm.Result.Visible && e.KeyChar == (char)Keys.Space)
            {
                mainForm.zakrytyButton_MouseClick(null, null);
            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                playButton_MouseClick(null, null);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                mainForm.backButton_MouseClick(null, null);
            }
            else if (e.KeyChar == 'd')
            {
                if (plusButton.ForeColor == Color.Black)
                {
                    plusButton_MouseClick(null, null);
                    plusButton.ForeColor = Color.Black;
                }
                else
                    plusButton_MouseClick(null, null);
            }
            else if (e.KeyChar == 'a')
            {
                if (minusButton.ForeColor == Color.Black)
                {
                    minusButton_MouseClick(null, null);
                    minusButton.ForeColor = Color.Black;
                }
                else
                    minusButton_MouseClick(null, null);
            }
        }

    }
}
