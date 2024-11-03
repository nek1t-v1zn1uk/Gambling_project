namespace Gambling
{
    public partial class MainForm : Form
    {
        public bool isMusic = true;
        public bool isSound = true;
        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;
        }

        public void setUserControl(UserControl control)
        {
            MainPanel.SuspendLayout();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
            MainPanel.ResumeLayout();
        }

       

        private async void MainForm_Shown(object sender, EventArgs e)
        {

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
    }
}
