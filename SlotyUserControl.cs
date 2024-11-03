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
        private List<byte> baraban1 = new List<byte>(3), baraban2 = new List<byte>(3), baraban3 = new List<byte>(3);
        private Random random = new Random();

        private double speed = 100;
        private int yy = -183;

        private const int sizeX = 312, sizeY = 181;

        private Image[] fruits = new Image[4];
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
            bars = Properties.Resources.slots_bars;

            sloty.Location = new Point((int)(Width / 5.333), (int)(Height / 26.341));
            sloty.Size = new Size((int)(Width / 1.6), (int)(Width / 2.4));

            krutytyButton.Width = (int)(Width / 4.267);
            krutytyButton.Height = (int)(krutytyButton.Width / 3.6);
            krutytyButton.Location = new Point((int)((Width - krutytyButton.Width) / 2), (int)(Height / 1.2));

            x = y = (int)(sloty.Width / 9.23);

            baraban1.Clear();
            baraban2.Clear();
            baraban3.Clear();

            for (int i = 0; i < 4; i++)
            {
                baraban1.Add((byte)random.Next(0, 4));
                baraban2.Add((byte)random.Next(0, 4));
                baraban3.Add((byte)random.Next(0, 4));
            }

            using (Graphics g = Graphics.FromImage(sloty.Image))
            {
                g.Clear(Color.Transparent);

                for (int i = 0; i < 4; i++)
                {
                    g.DrawImage(fruits[baraban1[i]], x, y + yy + i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[baraban2[i]], x + sizeX, y + yy + i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[baraban3[i]], x + sizeX * 2, y + yy + i * sizeY, sizeX, sizeY);
                }
                //рамка
                g.DrawImage(Properties.Resources.slots_bars_2, 0, 0, sloty.Width, sloty.Height);
            }

        }


        public async void spin()
        {
            yy = 0;
            speed = 100;
            Stopwatch stopwatch = new Stopwatch();
            int count = 19;
            Bitmap bufferImage = new Bitmap(sizeX*3, count * sizeY);
            using (Graphics g = Graphics.FromImage(bufferImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;


                for (int i = 3; i < count-3; i++) {
                    g.DrawImage(fruits[random.Next(0, 4)], 0, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[random.Next(0, 4)], sizeX, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[random.Next(0, 4)], sizeX * 2, i * sizeY, sizeX, sizeY);
                }

                for (int i = count-3; i < count; i++)
                {
                    g.DrawImage(fruits[baraban1[i - count + 3]], 0, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[baraban2[i - count + 3]], sizeX, i * sizeY, sizeX, sizeY);
                    g.DrawImage(fruits[baraban3[i - count + 3]], sizeX * 2, i * sizeY, sizeX, sizeY);
                }

                baraban1.Clear();
                baraban2.Clear();
                baraban3.Clear();

                for (int i = 0; i < 3; i++)
                {
                    baraban1.Add((byte)random.Next(0, 4));
                    g.DrawImage(fruits[baraban1[i]], 0, i * sizeY, sizeX, sizeY);
                    baraban2.Add((byte)random.Next(0, 4));
                    g.DrawImage(fruits[baraban2[i]], sizeX, i * sizeY, sizeX, sizeY);
                    baraban3.Add((byte)random.Next(0, 4));
                    g.DrawImage(fruits[baraban3[i]], sizeX * 2, i * sizeY, sizeX, sizeY);
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

                    if (speed <= 0)
                        speed = 1;
                    if (yy > (count - 3) * sizeY)
                    {
                        speed = 0;
                        yy = (count - 3) * sizeY;
                    }

                    using (Graphics gr = Graphics.FromImage(img))
                    {
                        gr.Clear(Color.Transparent);

                        gr.DrawImage(bufferImage, new Rectangle(x, y, sizeX*3, sizeY*3), new Rectangle(0, (count - 3) * sizeY - yy, sizeX*3, sizeY*3), GraphicsUnit.Pixel);

                        //stopwatch.Stop();
                        //elapsed = (int)stopwatch.ElapsedMilliseconds;
                        //label1.Text = label1.Text + " " + elapsed;
                        //stopwatch.Restart();

                        gr.DrawImage(bars, 0, 0, sloty.Width, sloty.Height);

                        //gr.DrawImage(bufferImage, 0, 0, sloty.Width / 10, sloty.Height);
                    }

                    //stopwatch.Stop();
                    //elapsed = (int)stopwatch.ElapsedMilliseconds;
                    //label1.Text = label1.Text + " " + elapsed;
                    //stopwatch.Restart();

                    sloty.Image = img;

                    //stopwatch.Stop();
                    //elapsed = (int)stopwatch.ElapsedMilliseconds;
                    //label1.Text = label1.Text + " " + elapsed;
                    //stopwatch.Restart();

                    //time++;
                    speed -= 1.7;
                    
                    ////if (speed <= 0)
                    //    //speed = 1;
                    //if (yy >= 0)
                    //{
                    //    if (speed == 1)
                    //        speed = 0;
                    //    //yy = -183;
                    //    koef++;
                    //}

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
        }

        private void krutytyButton_MouseClick(object sender, MouseEventArgs e)
        {
            spin();
        }

        private void krutytyButton_MouseDown(object sender, MouseEventArgs e)
        {
            krutytyButton.Image = Properties.Resources.krutity_clicked;
        }
        private void krutytyButton_MouseEnter(object sender, EventArgs e)
        {
            krutytyButton.Image = Properties.Resources.krutity_hovered;
        }
        private void krutytyButton_MouseLeave(object sender, EventArgs e)
        {
            krutytyButton.Image = Properties.Resources.krutity;
        }
        private void krutytyButton_MouseUp(object sender, MouseEventArgs e)
        {
            krutytyButton.Image = Properties.Resources.krutity;
        }

    }
}
