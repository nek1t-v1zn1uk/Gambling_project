using System.Windows.Forms;

namespace Gambling
{
    public partial class MainForm : Form
    {
        public bool isMusic = true;
        public bool isSound = true;
        public int countToJecpot;
        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;
        }

        public void setUserControl(UserControl control)
        {
            MainPanel.SuspendLayout();
            UserControl cont = (UserControl)MainPanel.Controls[0];
            if (cont is FortunkaUserControl f)
                f.Cancel();
            else if (cont is SlotyUserControl s)
                s.Cancel();
            MainPanel.Controls.Clear();
            cont.Dispose();
            cont = null;
            MainPanel.Controls.Add(control);
            MainPanel.ResumeLayout();
            backButton.Visible = true;
            MainPanel.Controls[0].Focus();
        }



        private async void MainForm_Shown(object sender, EventArgs e)
        {
            backButton.Location = new Point(35, 35);
            backButton.Size = new Size(75, 75);

            //axWindowsMediaPlayer1.Enabled = false;

            MainPanel.Location = new Point(0, 0);
            MainPanel.Size = ClientSize;
            MainUserControl control = new MainUserControl(MainPanel.Size, this);
            //SlotyUserControl control = new SlotyUserControl(MainPanel.Size, this);
            MainPanel.Controls.Add(control);


            //string videoPath = System.IO.Path.Combine(Application.StartupPath, "Resources", "red dice.mp4");

            //// Check if the video file exists before playing
            //if (System.IO.File.Exists(videoPath))
            //{
            //    axWindowsMediaPlayer1.Visible = true;
            //    axWindowsMediaPlayer1.URL = videoPath;
            //    axWindowsMediaPlayer1.windowlessVideo = true;
            //    axWindowsMediaPlayer1.uiMode = "none";
            //    axWindowsMediaPlayer1.Dock = DockStyle.Fill;

            //    await Task.Delay(5000);

            //    // Stop the video after 5 seconds
            //    axWindowsMediaPlayer1.Ctlcontrols.stop();
            //    axWindowsMediaPlayer1.Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("Video file not found: " + videoPath);
            //}

            axWindowsMediaPlayer1.Dispose();
        }

        public void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (MainPanel.Controls[0] is MenuUserControl || MainPanel.Controls[0] is SettingsUserControl)
            {
                setUserControl(new MainUserControl(Size, this));
                backButton.Visible = false;
            }
            else if (MainPanel.Controls[0] is SlotyUserControl || MainPanel.Controls[0] is FortunkaUserControl
                || MainPanel.Controls[0] is KostyUserControl)
                setUserControl(new MenuUserControl(Size, this));
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

    }
}
