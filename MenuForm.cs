namespace Gambling
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            int baseWidth = width - 20;
            int baseHeight = height / 4;
            int possibleWidth = (int)(baseHeight / 0.375);
            int possibleHeight = (int)(baseWidth * 0.375);
            if (baseWidth < possibleWidth && baseHeight > possibleHeight)
            {
                slotyButton.Width = baseWidth;
                slotyButton.Height = possibleHeight;
                ruletkaButton.Width = baseWidth;
                ruletkaButton.Height = possibleHeight;
                kostyButton.Width = baseWidth;
                kostyButton.Height = possibleHeight;
            }
            else
            {
                slotyButton.Width = possibleWidth;
                slotyButton.Height = baseHeight;
                ruletkaButton.Width = possibleWidth;
                ruletkaButton.Height = baseHeight;
                kostyButton.Width = possibleWidth;
                kostyButton.Height = baseHeight;
            }
            if (slotyButton.Width > 400)
            {
                slotyButton.Width = 400;
                slotyButton.Height = 150;
                ruletkaButton.Width = 400;
                ruletkaButton.Height = 150;
                kostyButton.Width = 400;
                kostyButton.Height = 150;
            }
            int x = (width - slotyButton.Width) / 2;
            int y = (int)(height - (slotyButton.Height * 3.15));
            if (y > height * 0.4)
                y = (int)(height * 0.4);
            slotyButton.Location = new Point(x, y);
            ruletkaButton.Location = new Point(x, (int)(y + ruletkaButton.Height * 1.05));
            kostyButton.Location = new Point(x, (int)(y + kostyButton.Height * 2.1));
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
        }
        private void slotyButton_MouseLeave(object sender, EventArgs e)
        {
            slotyButton.Image = Properties.Resources.sloty;
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
        }
        private void ruletkaButton_MouseLeave(object sender, EventArgs e)
        {
            ruletkaButton.Image = Properties.Resources.ruletka;
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
        }
        private void kostyButton_MouseLeave(object sender, EventArgs e)
        {
            kostyButton.Image = Properties.Resources.kostya;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
