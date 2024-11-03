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
        private List<byte> baraban1 = new List<byte>(4), baraban2 = new List<byte>(4), baraban3 = new List<byte>(4);
        private Random random = new Random();

        private int time = 0, koef = 1, speed = 100;
        private int yy = -183;

        private Image[] fruits = new Image[4];


        public SlotyUserControl(Size size, MainForm form)
        {
            InitializeComponent();

            mainForm = form;
            Size = size;
            Load();

        }

        public void Load()
        {

            fruits[0] = new Bitmap(Properties.Resources.Banana_Slot, new Size(153, 89)); 
            fruits[1] = new Bitmap(Properties.Resources.Orange_Slot, new Size(153, 89));
            fruits[2] = new Bitmap(Properties.Resources.Cherry_Slot, new Size(153, 89));
            fruits[3] = new Bitmap(Properties.Resources.Watermelon_Slot, new Size(153, 89));

            sloty.Location = new Point((int)(Width / 5.333), (int)(Height / 26.341));
            sloty.Size = new Size((int)(Width / 1.6), (int)(Width / 2.4));

            krutytyButton.Width = (int)(Width / 4.267);
            krutytyButton.Height = (int)(krutytyButton.Width / 3.6);
            krutytyButton.Location = new Point((int)((Width - krutytyButton.Width) / 2), (int)(Height / 1.2));

            x = y = (int)(sloty.Width / 9.23);

            baraban1.Clear();
            baraban2.Clear();
            baraban3.Clear();
            for (int i = 0; i < 15; i++)
            {
                baraban1.Add((byte)random.Next(1, 5));
                baraban2.Add((byte)random.Next(1, 5));
                baraban3.Add((byte)random.Next(1, 5));
            }

            baraban1.Clear();
            baraban2.Clear();
            baraban3.Clear();

            for (int i = 0; i < 4; i++)
            {
                baraban1.Add((byte)random.Next(1, 5));
                baraban2.Add((byte)random.Next(1, 5));
                baraban3.Add((byte)random.Next(1, 5));
            }

            using (Graphics g = Graphics.FromImage(sloty.Image))
            {
                g.Clear(Color.Transparent);

                for (int i = 0; i < 4; i++)
                {
                    g.DrawImage(fruits[baraban1[i] - 1], x, y + yy + i * 183, 307, 179);
                    g.DrawImage(fruits[baraban2[i] - 1], x + 311, y + yy + i * 183, 307, 179);
                    g.DrawImage(fruits[baraban3[i] - 1], x + 622, y + yy + i * 183, 307, 179);
                }
                //рамка
                g.DrawImage(Properties.Resources.slots_bars_2, 0, 0, sloty.Width, sloty.Height);
            }

        }


        public async void spin()
        {
            yy = -183;
            time = 0;
            koef = 1;
            speed = 100;
            Stopwatch stopwatch = new Stopwatch();

            Bitmap bufferImage = new Bitmap(sloty.Width, sloty.Height);
            using (Graphics g = Graphics.FromImage(bufferImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

                while (speed > 0)
                {
                    stopwatch.Restart();

                    await Task.Run(() =>
                    {
                        g.Clear(Color.Transparent);

                        yy += speed;
                        for (int i = 0; i < 4; i++)
                        {
                            g.DrawImage(fruits[baraban1[i] - 1], x, y + yy + i * 183, 307, 179);
                            g.DrawImage(fruits[baraban2[i] - 1], x + 311, y + yy + i * 183, 307, 179);
                            g.DrawImage(fruits[baraban3[i] - 1], x + 622, y + yy + i * 183, 307, 179);

                        }
                    });

                    //рамка
                    g.DrawImage(Properties.Resources.slots_bars_2, 0, 0, sloty.Width, sloty.Height);

                    sloty.Image = (Bitmap)bufferImage.Clone();
                    sloty.Invalidate();

                    //await Task.Delay(16);
                    time++;
                    speed -= 2;
                    if (speed <= 0)
                        speed = 1;
                    if (yy >= 0)
                    {
                        if (speed == 1)
                            speed = 0;
                        yy = -183;
                        koef++;
                        baraban1.RemoveAt(3);
                        baraban2.RemoveAt(3);
                        baraban3.RemoveAt(3);
                        baraban1.Insert(0, (byte)random.Next(1, 5));
                        baraban2.Insert(0, (byte)random.Next(1, 5));
                        baraban3.Insert(0, (byte)random.Next(1, 5));
                    }

                    stopwatch.Stop();
                    int elapsed = (int)stopwatch.ElapsedMilliseconds;
                    int delayTime = 60 - elapsed;
                    if (delayTime > 0)
                    {
                        await Task.Delay(delayTime);
                    }
                    label1.Text = label1.Text + " " + elapsed;
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
