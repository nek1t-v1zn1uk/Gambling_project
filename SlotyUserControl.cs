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

namespace Gambling
{
    public partial class SlotyUserControl : UserControl
    {
        public MainForm mainForm;

        private int x, y, slotW, slotH;
        private List<byte> baraban1 = new List<byte>(4), baraban2 = new List<byte>(4), baraban3 = new List<byte>(4);
        private Random random = new Random();

        private int time = 0, koef = 1, speed = 100;


        public SlotyUserControl(Size size, MainForm form)
        {
            InitializeComponent();

            mainForm = form;
            Size = size;
            Load();

        }

        public void Load()
        {
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
        }

        public async void spin()
        {
            baraban1.Clear();
            baraban2.Clear();
            baraban3.Clear();

            for (int i = 0; i < 4; i++)
            {
                baraban1.Add((byte)random.Next(1, 5));
                baraban2.Add((byte)random.Next(1, 5));
                baraban3.Add((byte)random.Next(1, 5));
            }
            int yy = -183;
            time = 0;
            using (Graphics g = Graphics.FromImage(sloty.Image))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                
                while (speed>0) {
                    g.Clear(Color.Transparent);

                    //yy = time * speed - koef * 183;
                    yy += speed;
                    for (int i = 0; i < 4; i++)
                    {
                        g.DrawImage(getImage(baraban1[i]), x      , y + yy + i * 183, 307, 179);
                        g.DrawImage(getImage(baraban2[i]), x + 311, y + yy + i * 183, 307, 179);
                        g.DrawImage(getImage(baraban3[i]), x + 622, y + yy + i * 183, 307, 179);

                    }


                    //рамка
                    g.DrawImage(Properties.Resources.slots_bars_2, 0, 0, sloty.Width, sloty.Height);

                    await Task.Delay(16);
                    sloty.Invalidate();
                    time++;
                    speed-=2;
                    if (yy>=0)
                    {
                        yy = -183;
                        koef++;
                        baraban1.RemoveAt(3);
                        baraban2.RemoveAt(3);
                        baraban3.RemoveAt(3);
                        baraban1.Insert(0, (byte)random.Next(1, 5));
                        baraban2.Insert(0, (byte)random.Next(1, 5));
                        baraban3.Insert(0, (byte)random.Next(1, 5));
                    }
                }
            }
        }

        private void krutytyButton_MouseClick(object sender, MouseEventArgs e)
        {
            spin();
        }

        private static Image getImage(byte n)
        {
            switch (n)
            {
                case 1: return Properties.Resources.Banana_Slot;
                case 2: return Properties.Resources.Orange_Slot;
                case 3: return Properties.Resources.Cherry_Slot;
                case 4: return Properties.Resources.Watermelon_Slot;
                default: return null;
            }
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
