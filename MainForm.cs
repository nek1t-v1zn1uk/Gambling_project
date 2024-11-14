using System.Windows.Forms;

namespace Gambling
{
    public partial class MainForm : Form
    {
        public bool isMusic = true;
        public bool isSound = true;

        public double rakhunok = 0;

        public int countToJecpot;

        private Font resultFont;
        private Brush resultBrush;
        private Size bannerSize;
        private Point bannerLocation;

        Image baseBackIm;
        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;

            ChangeRakhunok(0);
        }

        public void setUserControl(UserControl control)
        {
            MainPanel.SuspendLayout();
            UserControl cont = (UserControl)MainPanel.Controls[1];
            if (cont is FortunkaUserControl f)
                f.Cancel();
            else if (cont is SlotyUserControl s)
                s.Cancel();
            else if (cont is KostyUserControl k)
                k.Cancel();
            MainPanel.Controls.Remove(cont);
            cont.Dispose();
            cont = null;
            MainPanel.Controls.Add(control);
            MainPanel.ResumeLayout();
            backButton.Visible = true;
            MainPanel.Controls[1].Focus();
            BackgroundImage = MainPanel.Controls[1].BackgroundImage;
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            baseBackIm = BackgroundImage;

            backButton.Location = new Point(35, 35);
            backButton.Size = new Size(75, 75);

            //axWindowsMediaPlayer1.Enabled = false;

            bannerSize = new Size((int)(Width / 3), (int)(Width / 6));
            bannerLocation = new Point((int)((Width - bannerSize.Width) / 2), (int)((Height - bannerSize.Height) / 2));
            Result.Size = Size;
            Result.Location = new Point(0, 0);
            Result.Visible = false;

            zakrytyButton.Size = new Size((int)(bannerSize.Width / 2.5), (int)(bannerSize.Width / 2.5 / 6.667));
            zakrytyButton.Location = new Point((int)(bannerLocation.X + (bannerSize.Width - zakrytyButton.Width) / 2),
                (int)(bannerLocation.Y + bannerSize.Height / 1.2));
            zakrytyButton.Visible = false;

            resultFont = new Font("Days One", (int)30);
            resultBrush = new SolidBrush(Color.Black);

            rakhunokLabel.Size = new Size(700, 75);
            rakhunokLabel.Location = new Point(Width-rakhunokLabel.Width-rakhunokLabel.Height, 
                (int)(rakhunokLabel.Height / 2));


            MainPanel.Location = new Point(0, 0);
            MainPanel.Size = ClientSize;
            MainUserControl control = new MainUserControl(MainPanel.Size, this);
            //SlotyUserControl control = new SlotyUserControl(MainPanel.Size, this);
            MainPanel.Controls.Add(control);

            string videoPath = System.IO.Path.Combine(Application.StartupPath, "Resources", "red dice.mp4");

            // Check if the video file exists before playing
            if (System.IO.File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.windowlessVideo = true;
                axWindowsMediaPlayer1.uiMode = "none";
                axWindowsMediaPlayer1.Dock = DockStyle.Fill;

                await Task.Delay(5000);

                // Stop the video after 5 seconds
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Visible = false;
            }
            else
            {
                MessageBox.Show("Video file not found: " + videoPath);
            }

            axWindowsMediaPlayer1.Dispose();
        }

        public void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (MainPanel.Controls[1] is MenuUserControl || MainPanel.Controls[1] is SettingsUserControl
                || MainPanel.Controls[1] is RakhunokUserControl)
            {
                setUserControl(new MainUserControl(Size, this));
                backButton.Visible = false;
            }
            else if (MainPanel.Controls[1] is SlotyUserControl || MainPanel.Controls[1] is FortunkaUserControl
                || MainPanel.Controls[1] is KostyUserControl)
                setUserControl(new MenuUserControl(Size, this));
            if (Result.Visible)
            {
                zakrytyButton_MouseClick(null, null);
            }
        }

        public bool ChangeRakhunok(double s)
        {
            rakhunok += Math.Round(s, 2);
            rakhunok = Math.Round(rakhunok, 2);
            if (rakhunok<0)
                return false;

            if (rakhunok > 999999999999999)
                rakhunok = 999999999999999;
            rakhunokLabel.Text = rakhunok.ToString();
            return true;
        }

        public void ShowResult(double sum)
        {
            sum = Math.Round(sum, 2);
            Image im = CaptureScreen();
            string text = "Ваш виграш: " + sum;
            using (Graphics g = Graphics.FromImage(im))
            {
                g.DrawImage(Properties.Resources.Result, bannerSize.Width, bannerSize.Height, bannerLocation.X, bannerLocation.Y);
                SizeF textSize = g.MeasureString(text, resultFont);
                g.DrawString(text, resultFont, resultBrush, new Point((int)(bannerLocation.X + (bannerSize.Width - textSize.ToSize().Width) / 2), (int)(bannerLocation.Y + (bannerSize.Height - textSize.Height) / 2.4)));
            }
            Result.Image = im;
            baseBackIm = BackgroundImage;
            rakhunokLabel.Visible = false;
            BackgroundImage = im;
            Result.Visible = true;
            zakrytyButton.Visible = true;
        }

        public Image CaptureScreen()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height);
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(screenBounds.Location, Point.Empty, screenBounds.Size);
            }
            return screenshot;
        }

        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
            backButton.Image = Properties.Resources.Back_button_clicked;
        }
        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.Back_button_hovered;
        }
        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.Back_button;
        }
        private void backButton_MouseUp(object sender, MouseEventArgs e)
        {
            backButton.Image = Properties.Resources.Back_button;
        }

        public void zakrytyButton_MouseClick(object sender, MouseEventArgs e)
        {
            zakrytyButton.Visible = false;
            Result.Visible = false;
            BackgroundImage = baseBackIm;
            rakhunokLabel.Visible = true; 
        }

        private void zakrytyButton_MouseDown(object sender, MouseEventArgs e)
        {
            zakrytyButton.Image = Properties.Resources.zakrity_closed;
        }

        private void zakrytyButton_MouseEnter(object sender, EventArgs e)
        {
            zakrytyButton.Image = Properties.Resources.zakrity;
        }

        private void zakrytyButton_MouseLeave(object sender, EventArgs e)
        {
            zakrytyButton.Image = Properties.Resources.zakrity_hovered;
        }

        private void zakrytyButton_MouseUp(object sender, MouseEventArgs e)
        {
            zakrytyButton.Image = Properties.Resources.zakrity_hovered;
        }

    }
}
