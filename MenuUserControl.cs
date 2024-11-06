using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gambling
{
    public partial class MenuUserControl : UserControl
    {
        public MainForm mainForm;
        private float opacity = -2;
        private Image preview;
        private bool isShow = true;
        public MenuUserControl(Size size, MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            this.Size = size;
            Load();
        }
        public void Load()
        {
            int x, y, p, w, h;
            w = (int)(Width / 4.266);
            h = (int)(w / 2.666);
            x = (int)((Width - w) / 2);
            y = (int)(Height / 4.39);
            p = (int)((Height - h * 3 - y * 2) / 2);
            slotyButton.Size = new Size(w, h);
            slotyButton.Location = new Point(x, y);
            ruletkaButton.Size = new Size(w, h);
            ruletkaButton.Location = new Point(x, y + h + p);
            kostyButton.Size = new Size(w, h);
            kostyButton.Location = new Point(x, y + 2 * (h + p));

            pictureBox1.Size = new Size((int)(Width / 4.266), (int)(Height / 1.815));
            pictureBox1.Location = new Point((int)(Width / 1.525), (Height - pictureBox1.Height) / 2);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                opacity += 0.1f;
                if (opacity > 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = AdjustImageOpacity(preview, opacity);
                }
                if (opacity >= 1)
                    timer1.Stop();
            }
            else
            {
                opacity -= 0.1f;
                if (opacity <= 0)
                {
                    timer1.Stop();
                    opacity = -2;
                }
                else
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = AdjustImageOpacity(preview, opacity);
                }
                
            }
            
        }

        //зміна прозорості зображення
        private Image AdjustImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void slotyButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.setUserControl(new SlotyUserControl(Size, mainForm));
        }

        private void ruletkaButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.setUserControl(new FortunkaUserControl(Size, mainForm));
        }

        private void kostyButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.setUserControl(new KostyUserControl(Size, mainForm));
        }



        private void slotyButton_MouseDown(object sender, MouseEventArgs e)
        {
            slotyButton.Image = Properties.Resources.sloty_clicked;
        }
        private void slotyButton_MouseUp(object sender, MouseEventArgs e)
        {
            slotyButton.Image = Properties.Resources.sloty_hovered;
        }
        private void slotyButton_MouseEnter(object sender, EventArgs e)
        {
            slotyButton.Image = Properties.Resources.sloty_hovered;

            preview = Properties.Resources.sloty_preview;
            isShow = true;
            timer1.Start();
        }
        private void slotyButton_MouseLeave(object sender, EventArgs e)
        {
            slotyButton.Image = Properties.Resources.sloty;

            isShow = false;
            timer1.Start();
        }
        private void ruletkaButton_MouseDown(object sender, MouseEventArgs e)
        {
            ruletkaButton.Image = Properties.Resources.ruletka_clicked;
        }
        private void ruletkaButton_MouseUp(object sender, MouseEventArgs e)
        {
            ruletkaButton.Image = Properties.Resources.ruletka_hovered;
        }
        private void ruletkaButton_MouseEnter(object sender, EventArgs e)
        {
            ruletkaButton.Image = Properties.Resources.ruletka_hovered;

            preview = Properties.Resources.ruletka_preview;
            isShow = true;
            timer1.Start();
        }
        private void ruletkaButton_MouseLeave(object sender, EventArgs e)
        {
            ruletkaButton.Image = Properties.Resources.ruletka;

            isShow = false;
            timer1.Start();
        }
        private void kostyButton_MouseDown(object sender, MouseEventArgs e)
        {
            kostyButton.Image = Properties.Resources.kostya_clicked;
        }
        private void kostyButton_MouseUp(object sender, MouseEventArgs e)
        {
            kostyButton.Image = Properties.Resources.kostya_hovered;
        }
        private void kostyButton_MouseEnter(object sender, EventArgs e)
        {
            kostyButton.Image = Properties.Resources.kostya_hovered;

            preview = Properties.Resources.kosty_preview;
            isShow = true;
            timer1.Start();
        }
        private void kostyButton_MouseLeave(object sender, EventArgs e)
        {
            kostyButton.Image = Properties.Resources.kostya;

            isShow = false;
            timer1.Start();
        }

        private void UserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                mainForm.backButton_MouseClick(null, null);
            }
        }
    }
}
