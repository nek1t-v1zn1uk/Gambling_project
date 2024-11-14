using System;
using System.Collections;
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

        private TransparentTextBox transparentTextBox;

        private bool isSpin = false;
        int winPos; //x1; l; x3; l; x1; l; x2; l; x1; l; x5; l; x1; l; x2; l
        private double speed = 100, angle = 0, baseAngle;

        private int stavka;

        private Random random = new Random();

        private Image wheelImage, frame;

        private bool canSpin = true;

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

            int w = (int)(Width / 4.244);
            stavkaPicture.Size = new Size(w, (int)(w / 6.75));
            stavkaPicture.Location = new Point((Width - wheel.Width) / 3 * 4 - stavkaPicture.Width / 2, (int)(Height/3));
            stavkaInputBack.Size = new Size(w, (int)(w / 5));
            stavkaInputBack.Location = new Point(stavkaPicture.Location.X, stavkaPicture.Location.Y + stavkaPicture.Height + 15);

            AddTransparentTextBox();

            using (Graphics g = Graphics.FromImage(wheel.Image))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(wheelImage, 0, 0, wheel.Width, wheel.Height);
                g.DrawImage(frame, 0, 0, wheel.Width, wheel.Height);
            }
            wheel.Invalidate();
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

            transparentTextBox.Location = new Point((int)(stavkaInputBack.Location.X + (stavkaInputBack.Width / 12)),
                stavkaInputBack.Location.Y + 2);
            transparentTextBox.Size = new Size((int)(stavkaInputBack.Width / 6 * 5), stavkaInputBack.Height);
            transparentTextBox.Font = new Font("Days One", (int)(transparentTextBox.Height * 2));

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
            if (transparentTextBox.Text != "" && int.Parse(transparentTextBox.Text) > mainForm.rakhunok)
            {
                transparentTextBox.Text = Math.Floor(mainForm.rakhunok).ToString();
            }
        }

        private async void spin()
        {
            isSpin = true;
            transparentTextBox.Enabled = false;
            Focus();

            winPos = random.Next(0, 15);
            baseAngle = 360 - (winPos * 360 / 16 + 6 - random.Next(0, 20));
            baseAngle = baseAngle % 360;
            double maxSpeed = 20;
            double acceleration = 0.5;
            double difference = 100;
            int fullRotations = 3;

            speed = 1; 

            bool isGood = false;

            Bitmap bufferImage = new Bitmap(wheel.Width, wheel.Height);
            using (Graphics gBuffer = Graphics.FromImage(bufferImage))
            {
                gBuffer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                gBuffer.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                while (fullRotations > 0 || Math.Abs(angle - baseAngle) >= 1.5 || speed !=1)
                {
                    if (canSpin == false)
                        return;


                    if (fullRotations <= 0 && speed > 1 && (baseAngle - angle < difference ||
                        baseAngle < difference && (angle > 360 - difference + baseAngle || angle < baseAngle)))
                        isGood = true;


                    if (fullRotations > 0 && speed < maxSpeed)
                    {
                        speed += acceleration;
                    }
                    else if (fullRotations <= 0 && speed > 1 && isGood)
                    {
                        speed -= acceleration;
                        if (speed < 1) speed = 1;
                    }

                    angle += speed;
                    if (angle >= 360)
                    {
                        angle -= 360;
                        fullRotations--;
                    }

                    gBuffer.Clear(Color.Transparent);
                    gBuffer.TranslateTransform(bufferImage.Width / 2f, bufferImage.Height / 2f);
                    gBuffer.RotateTransform((float)angle);
                    gBuffer.TranslateTransform(-wheelImage.Width / 2f, -wheelImage.Height / 2f);
                    gBuffer.DrawImage(wheelImage, 0, 0, wheel.Width, wheel.Height);
                    gBuffer.ResetTransform();
                    gBuffer.DrawImage(frame, 0, 0, wheel.Width, wheel.Height);

                    wheel.Image = (Bitmap)bufferImage.Clone();
                    wheel.Invalidate();
                    await Task.Delay(16);
                }
            }
            mainForm.ChangeRakhunok(dict[winPos]*stavka);
            mainForm.ShowResult(dict[winPos]*stavka);
            isSpin = false;
            transparentTextBox.Enabled = true;
            krutytyButton.Image = Properties.Resources.krutity;
        }


        public void Cancel()
        {
            canSpin = false;
        }


        private void krutytyButton_MouseClick(object sender, MouseEventArgs e)
        {
            CheckStavka();
            if (!isSpin && transparentTextBox.Text != "" && int.Parse(transparentTextBox.Text) > 0)
            {
                stavka = int.Parse(transparentTextBox.Text);
                mainForm.ChangeRakhunok(-stavka);
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

        private void UserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mainForm.Result.Visible && e.KeyChar == (char)Keys.Space)
            {
                mainForm.zakrytyButton_MouseClick(null, null);
            }
            else if (e.KeyChar == (char)Keys.Space)
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
