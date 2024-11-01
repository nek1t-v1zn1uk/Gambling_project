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
    public partial class MainUserControl : UserControl
    {
        public MainForm mainForm;
        public MainUserControl(Size size, MainForm form)
        {
            InitializeComponent();

            mainForm = form;
            this.Size = size;
            Load();
        }
        public async void Load()
        {
            int x, y, p, w, h;
            w = (int)(Width / 4.266);
            h = (int)(w / 3.6);
            x = (int)((Width - w) / 2);
            y = (int)(Height / 4.39);
            p = (int)((Height - h * 4 - y * 2) / 3);
            gamblingButton.Size = new Size(w, h);
            gamblingButton.Location = new Point(x, y);
            rakhunokButton.Size = new Size(w, h);
            rakhunokButton.Location = new Point(x, y + h + p);
            settingsButton.Size = new Size(w, h);
            settingsButton.Location = new Point(x, y + 2 * (h + p));
            exitButton.Size = new Size(w, h);
            exitButton.Location = new Point(x, y + 3 * (h + p));
        }


        private void gamblingButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.setUserControl(new MenuUserControl(Size, mainForm));
        }

        private void exitButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.Close();
        }


        //функції для зміни зображення кнопки
        private void gamblingButton_MouseEnter(object sender, EventArgs e)
        {
            gamblingButton.Image = Properties.Resources.gambling_hovered;
        }
        private void gamblingButton_MouseLeave(object sender, EventArgs e)
        {
            gamblingButton.Image = Properties.Resources.gambling;
        }
        private void gamblingButton_MouseDown(object sender, MouseEventArgs e)
        {
            gamblingButton.Image = Properties.Resources.gambling_clicked;
        }
        private void gamblingButton_MouseUp(object sender, MouseEventArgs e)
        {
            gamblingButton.Image = Properties.Resources.gambling;
        }
        private void rakhunokButton_MouseEnter(object sender, EventArgs e)
        {
            rakhunokButton.Image = Properties.Resources.rahunok_hovered;
        }
        private void rakhunokButton_MouseLeave(object sender, EventArgs e)
        {
            rakhunokButton.Image = Properties.Resources.rahunok;
        }
        private void rakhunokButton_MouseDown(object sender, MouseEventArgs e)
        {
            rakhunokButton.Image = Properties.Resources.rahunok_;
        }
        private void rakhunokButton_MouseUp(object sender, MouseEventArgs e)
        {
            rakhunokButton.Image = Properties.Resources.rahunok;
        }
        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.nalashtuvanya_hovered;
        }
        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.Image = Properties.Resources.nalashtuvanya;
        }
        private void settingsButton_MouseDown(object sender, MouseEventArgs e)
        {
            settingsButton.Image = Properties.Resources.nalashtuvanya_clidked;
        }
        private void settingsButton_MouseUp(object sender, MouseEventArgs e)
        {
            settingsButton.Image = Properties.Resources.nalashtuvanya;
        }
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.vihid_hovered;
        }
        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = Properties.Resources.vihid;
        }
        private void exitButton_MouseDown(object sender, MouseEventArgs e)
        {
            exitButton.Image = Properties.Resources.vihid_clicked;
        }
        private void exitButton_MouseUp(object sender, MouseEventArgs e)
        {
            exitButton.Image = Properties.Resources.vihid;
        }
    }
}
