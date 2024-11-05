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
    public partial class SettingsUserControl : UserControl
    {
        public MainForm mainForm;
        public SettingsUserControl(Size size, MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            this.Size = size;
            Load();
        }

        public void Load()
        {
            SomeText.Width = (int)(Width / 5);
            SomeText.Height = (int)(SomeText.Width / 2.148);
            SomeText.Location = new Point((int)((Width * 1.05 - SomeText.Width) / 2), (int)((Height - SomeText.Height) / 2));

            musicButton.Size = new Size((int)(Height / 14), (int)(Height / 14));
            musicButton.Location = new Point((int)(Width * 0.369), (int)(Height / 2.52));

            soundButton.Size = musicButton.Size;
            soundButton.Location = new Point(musicButton.Location.X, (int)(Height / 1.91));

            if (mainForm.isMusic)
                musicButton.Image = Properties.Resources.sound;
            else
                musicButton.Image = Properties.Resources.no_sound;

            if (mainForm.isSound)
                soundButton.Image = Properties.Resources.sound;
            else
                soundButton.Image = Properties.Resources.no_sound;
        }

        private void musicButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.isMusic = !mainForm.isMusic;
            if (mainForm.isMusic)
                musicButton.Image = Properties.Resources.sound;
            else
                musicButton.Image = Properties.Resources.no_sound;
        }

        private void soundButton_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.isSound = !mainForm.isSound;
            if (mainForm.isSound)
                soundButton.Image = Properties.Resources.sound;
            else
                soundButton.Image = Properties.Resources.no_sound;
        }

        private void SlotyUserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                mainForm.backButton_MouseClick(null, null);
            }
        }
    }
}
