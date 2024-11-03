using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gambling
{
    public partial class FortunkaUserControl : UserControl
    {
        public MainForm mainForm;

        private bool isSpin = false;
        int winPos; //x1; l; x3; l; x1; l; x2; l; x1; l; x5; l; x1; l; x2; l
        private double speed = 100, angle = 0, baseAngle;

        private Random random = new Random();

        private Image wheelImage, frame;

        public static readonly Dictionary<int, int> dict = new Dictionary<int, int>
        {
            {0, 1},
            {1, 0},
            {2, 3},
            {3, 0},
            {4, 1},
            {5, 0},
            {6, 2},
            {7, 0},
            {8, 1},
            {9, 0},
            {10, 5},
            {11, 0},
            {12, 1},
            {13, 0},
            {14, 2},
            {15, 0}
        };

        public FortunkaUserControl(Size size, MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            Size = size;
            Load();
        }

        public void Load()
        {
            wheelImage = Properties.Resources.wheel_of_fortune_inside;
            frame = Properties.Resources.wheel_of_fortune_frame;

            krutytyButton.Width = (int)(Width / 4.267);
            krutytyButton.Height = (int)(krutytyButton.Width / 3.6);
            krutytyButton.Location = new Point((int)((Width - krutytyButton.Width) / 2), (int)(Height / 1.2));

            wheel.Size = new Size((int)(Width/2.656), (int)(Width / 2.656));
            wheel.Location = new Point((int)(Width / 3.211), (int)(Height / 10.8));

            using (Graphics g = Graphics.FromImage(wheel.Image))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(wheelImage, 0, 0, wheel.Width, wheel.Height);
                g.DrawImage(frame, 0, 0, wheel.Width, wheel.Height);
            }
            wheel.Invalidate();
        }

        private async void spin()
        {
            label1.Text = ":";

            isSpin = true;
            Stopwatch stopwatch = new Stopwatch();
            winPos = random.Next(0, 15);
            baseAngle = 360 - (winPos * 360 / 16 + 6 - random.Next(0, 20));
            speed = 0;
            byte ok = 0;
            bool b = false;
            Bitmap bufferImage = new Bitmap(wheel.Width, wheel.Height);
            using (Graphics g = Graphics.FromImage(bufferImage))
            {
                Bitmap rotatedWheel = new Bitmap(wheelImage.Width, wheelImage.Height);
                rotatedWheel.SetResolution(wheelImage.HorizontalResolution, wheelImage.VerticalResolution);
                while (Math.Abs(angle - baseAngle) >= 1.5 || speed !=1 || ok < 4)
                {
                    stopwatch.Restart();

                    if (angle > 360)
                    {
                        angle -= 360;
                        if (!b && ok<4)
                            ok++;
                        b = false;
                    }

                    if (!b && ok<4 && angle >= baseAngle)
                    {
                        ok++;
                        b = true;
                    }


                    if (ok == 4 && (baseAngle - angle <= 60 && baseAngle - angle > 35 || 360 + baseAngle - angle <= 60 && 360 + baseAngle - angle > 35))
                    {
                        ok = 5;
                    }


                    g.Clear(Color.Transparent);

                    using (Graphics gr = Graphics.FromImage(rotatedWheel))
                    {
                        // Центр координатної системи встановлюємо у центр зображення
                        gr.TranslateTransform((float)wheelImage.Width / 2, (float)wheelImage.Height / 2);

                        // Повертаємо на вказаний кут
                        gr.RotateTransform((float)(angle));

                        // Повертаємо координатну систему на початкову точку
                        gr.TranslateTransform(-(float)wheelImage.Width / 2, -(float)wheelImage.Height / 2);

                        // Малюємо вихідне зображення на новому з поворотом
                        gr.DrawImage(wheelImage, new Point(0, 0));
                    }

                    g.DrawImage(rotatedWheel, 0, 0, wheel.Width, wheel.Height);
                    g.DrawImage(frame, 0, 0, wheel.Width, wheel.Height);


                    wheel.Image = bufferImage;


                    if(ok<4 && speed < 20)
                        speed += 1;
                    else if (ok==5 && speed - 0.5 >= 1)
                        speed -= 0.5;
                    label2.Text = speed + "  " + ok + "  " + (baseAngle-angle);

                    angle += speed;

                    stopwatch.Stop();
                    int elapsed = (int)stopwatch.ElapsedMilliseconds;
                    int delayTime = 60 - elapsed;
                    if (delayTime > 0)
                    {
                        await Task.Delay(delayTime);
                    }

                    label1.Text = label1.Text + " " + elapsed;
                    label1.Text = label1.Text + "\n";
                }
            }
            MessageBox.Show(dict[winPos].ToString());
            label1.Text = dict[winPos].ToString() + "  " + baseAngle + "  " + angle;

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

    }
}
