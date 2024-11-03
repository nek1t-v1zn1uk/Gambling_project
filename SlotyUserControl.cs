using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Gambling
{
    public partial class SlotyUserControl : UserControl
    {
        public MainForm mainForm;

        private int x, y, slotW, slotH;
        private int[,] barabans = new int[3, 3];
        private Random random = new Random();

        private bool isSpin = false;

        private double speed = 100;
        private int yy = -183;

        private int sizeX = 312, sizeY = 181;

        private Image[] fruits = new Image[12];
        private Image bars;


        public SlotyUserControl(Size size, MainForm form)
        {
            InitializeComponent();

            mainForm = form;
            Size = size;
            Load();

        }

        public void Load()
        {
            fruits[0] = new Bitmap(Properties.Resources.Banana_Slot, new Size(sizeX, sizeY));
            fruits[1] = new Bitmap(Properties.Resources.Orange_Slot, new Size(sizeX, sizeY));
            fruits[2] = new Bitmap(Properties.Resources.Cherry_Slot, new Size(sizeX, sizeY));
            fruits[3] = new Bitmap(Properties.Resources.Watermelon_Slot, new Size(sizeX, sizeY));
            fruits[4] = new Bitmap(Properties.Resources.Banana_Blurred, new Size(sizeX, sizeY));
            fruits[5] = new Bitmap(Properties.Resources.Orange_Blurred, new Size(sizeX, sizeY));
            fruits[6] = new Bitmap(Properties.Resources.Cherry_Blurred, new Size(sizeX, sizeY));
            fruits[7] = new Bitmap(Properties.Resources.Watermelon_Blurred, new Size(sizeX, sizeY));

            fruits[8] = new Bitmap(Properties.Resources.Banana_Glow, new Size(sizeX, sizeY));
            fruits[9] = new Bitmap(Properties.Resources.Orange_Glow, new Size(sizeX, sizeY));
            fruits[10] = new Bitmap(Properties.Resources.Cherry_Glow, new Size(sizeX, sizeY));
            fruits[11] = new Bitmap(Properties.Resources.Watermelon_Glow, new Size(sizeX, sizeY));
            bars = Properties.Resources.slots_bars;

            sloty.Location = new Point((int)(Width / 5.333), (int)(Height / 26.341));
            sloty.Size = new Size((int)(Width / 1.6), (int)(Width / 2.4));

            krutytyButton.Width = (int)(Width / 4.267);
            krutytyButton.Height = (int)(krutytyButton.Width / 3.6);
            krutytyButton.Location = new Point((int)((Width - krutytyButton.Width) / 2), (int)(Height / 1.2));

            x = y = (int)(sloty.Width / 9.23);

            sizeX = (int)(Width / 6.1538);
            sizeY = (int)(sizeX / 1.724);


            byte r = (byte)random.Next(0, 4);
            for (int i = 0; i < 3; i++)
            {
                barabans[0, i] = r;
                barabans[1, i] = r;
                barabans[2, i] = r;
            }

            using (Graphics g = Graphics.FromImage(sloty.Image))
            {
                g.Clear(Color.Transparent);

                for (int i = 0; i < 3; i++)
                {
                    g.DrawImage(fruits[barabans[0, i]], x, y + i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[barabans[1, i]], x + sizeX, y + i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[barabans[2, i]], x + sizeX * 2, y + i * sizeY, sizeX, sizeY);
                }
                //рамка
                g.DrawImage(Properties.Resources.slots_bars_2, 0, 0, sloty.Width, sloty.Height);
            }

        }

        public async void spin()
        {
            isSpin = true;
            label1.Text = "#";
            yy = 0;
            speed = 100;
            Stopwatch stopwatch = new Stopwatch();
            int count = 19;
            Bitmap bufferImage = new Bitmap(sizeX * 3, count * sizeY);
            using (Graphics g = Graphics.FromImage(bufferImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;


                //блюрені між результатами
                for (int i = 6; i < count - 3; i++)
                {
                    g.DrawImage(fruits[random.Next(4, 8)], 0, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[random.Next(4, 8)], sizeX, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[random.Next(4, 8)], sizeX * 2, i * sizeY, sizeX, sizeY);
                }

                //неблюрені між результатми
                for (int i = 3; i < 6; i++)
                {
                    g.DrawImage(fruits[random.Next(0, 4)], 0, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[random.Next(0, 4)], sizeX, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[random.Next(0, 4)], sizeX * 2, i * sizeY, sizeX, sizeY);
                }

                //старі результати
                for (int i = count - 3; i < count; i++)
                {
                    g.DrawImage(fruits[barabans[0, i - count + 3] + 4], 0, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[barabans[1, i - count + 3] + 4], sizeX, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[barabans[2, i - count + 3] + 4], sizeX * 2, i * sizeY, sizeX, sizeY);
                }

                //для джекпоту
                //byte r = (byte)random.Next(0, 4);

                //нові результати
                for (int i = 0; i < 3; i++)
                {
                    //barabans[0, i] = r;
                    //barabans[1, i] = r;
                    //barabans[2, i] = r;
                    barabans[0, i] = (byte)random.Next(0, 4);
                    barabans[1, i] = (byte)random.Next(0, 4);
                    barabans[2, i] = (byte)random.Next(0, 4);
                    g.DrawImage(fruits[barabans[0, i]], 0, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[barabans[1, i]], sizeX, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[barabans[2, i]], sizeX * 2, i * sizeY, sizeX, sizeY);
                }

                Image im = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics grd = Graphics.FromImage(im))
                {
                    grd.DrawImage(bufferImage, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }
                pictureBox1.Image = im;

                Image img = new Bitmap(sloty.Width, sloty.Height);
                while (speed > 0)
                {
                    int elapsed;
                    stopwatch.Restart();
                    yy += (int)speed;

                    if (yy > (count - 3) * sizeY)
                    {
                        speed = 0;
                        yy = (count - 3) * sizeY;
                    }

                    using (Graphics gr = Graphics.FromImage(img))
                    {
                        gr.Clear(Color.Transparent);

                        gr.DrawImage(bufferImage, new Rectangle(x, y, sizeX * 3, sizeY * 3), new Rectangle(0, (count - 3) * sizeY - yy, sizeX * 3, sizeY * 3), GraphicsUnit.Pixel);

                        gr.DrawImage(bars, 0, 0, sloty.Width, sloty.Height);

                    }

                    sloty.Image = img;

                    speed -= 1.7;

                    stopwatch.Stop();
                    elapsed = (int)stopwatch.ElapsedMilliseconds;
                    int delayTime = 16 - elapsed;
                    if (delayTime > 0)
                    {
                        await Task.Delay(delayTime);
                    }

                    label1.Text = label1.Text + " " + elapsed;
                    label1.Text = label1.Text + "\n";
                }
            }

            check();
        }

        public void check()
        {
            int win = 1;
            Image img = new Bitmap(sloty.Width, sloty.Height);
            int[,] checks = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    checks[i, j] = barabans[i, j];
                }
            }
            using (Graphics g = Graphics.FromImage(img))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (barabans[0, i] == barabans[1, i] && barabans[1, i] == barabans[2, i])
                    {
                        win++;
                        if (checks[0, i] < 5)
                            checks[0, i] += 8;
                        if (checks[1, i] < 5)
                            checks[1, i] += 8;
                        if (checks[2, i] < 5)
                            checks[2, i] += 8;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    if (barabans[i, 0] == barabans[i, 1] && barabans[i, 1] == barabans[i, 2])
                    {
                        win++;
                        if (checks[i, 0] < 5)
                            checks[i, 0] += 8;
                        if (checks[i, 1] < 5)
                            checks[i, 1] += 8;
                        if (checks[i, 2] < 5)
                            checks[i, 2] += 8;
                    }
                }

                if (barabans[0, 0] == barabans[1, 1] && barabans[1, 1] == barabans[2, 2])
                {
                    win++;
                    if (checks[0, 0] < 5)
                        checks[0, 0] += 8;
                    if (checks[1, 1] < 5)
                        checks[1, 1] += 8;
                    if (checks[2, 2] < 5)
                        checks[2, 2] += 8;
                }
                if (barabans[2, 0] == barabans[1, 1] && barabans[1, 1] == barabans[0, 2])
                {
                    win++;
                    if (checks[2, 0] < 5)
                        checks[2, 0] += 8;
                    if (checks[1, 1] < 5)
                        checks[1, 1] += 8;
                    if (checks[0, 2] < 5)
                        checks[0, 2] += 8;
                }

                for (int i = 0; i < 3; i++)
                {
                    g.DrawImage(fruits[checks[0, i]], x, y + i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[checks[1, i]], x + sizeX, y + i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[checks[2, i]], x + sizeX * 2, y + i * sizeY, sizeX, sizeY);
                }

                //рамка
                g.DrawImage(Properties.Resources.slots_bars_2, 0, 0, sloty.Width, sloty.Height);


            }

            sloty.Image = img;
            if (win == 9)
                MessageBox.Show("ДЖЕКПОТ, ДЖЕКПОТ, ХУЙ ТЄ В РОТ", "ДЖЕКПОТ");
            else if (win > 1)
                MessageBox.Show("x" + win, "Виграш");

            isSpin = false;
            krutytyButton.Image = Properties.Resources.krutity;
        }

        private void krutytyButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isSpin)
            {
                spin();
                krutytyButton.Image = Properties.Resources.krutity_clicked;
            }
        }

        private void krutytyButton_MouseDown(object sender, MouseEventArgs e)
        {
            krutytyButton.Image = Properties.Resources.krutity_clicked;
        }
        private void krutytyButton_MouseEnter(object sender, EventArgs e)
        {
            if (!isSpin)
                krutytyButton.Image = Properties.Resources.krutity_hovered;
        }
        private void krutytyButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isSpin)
                krutytyButton.Image = Properties.Resources.krutity;
        }
        private void krutytyButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isSpin)
                krutytyButton.Image = Properties.Resources.krutity;
        }

        private void SlotyUserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                krutytyButton_MouseClick(null, null);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                mainForm.backButton_MouseClick(null, null);
            }
        }
    }
}
