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
    public partial class RakhunokUserControl : UserControl
    {

        public MainForm mainForm;

        public RakhunokUserControl(Size size, MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            this.Size = size;
            Load();
        }

        public void Load()
        {

        }



        private void pidtverdityButton_MouseDown(object sender, MouseEventArgs e)
        {
            pidtverdityButton.Image = Properties.Resources.pidtverdity_clicked;
        }

        private void pidtverdityButton_MouseEnter(object sender, EventArgs e)
        {
            pidtverdityButton.Image = Properties.Resources.pidtverdity_hovered;
        }

        private void pidtverdityButton_MouseLeave(object sender, EventArgs e)
        {
            pidtverdityButton.Image = Properties.Resources.pidtverdity;
        }

        private void pidtverdityButton_MouseUp(object sender, MouseEventArgs e)
        {
            pidtverdityButton.Image = Properties.Resources.pidtverdity;
        }
    }
}
