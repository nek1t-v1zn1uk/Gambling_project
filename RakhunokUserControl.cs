using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Gambling
{
    public partial class RakhunokUserControl : UserControl
    {
        
        public MainForm mainForm;
        private TransparentTextBox transparentTextBox;
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        public RakhunokUserControl(Size size, MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            this.Size = size;

            Load();
            AddTransparentTextBox();
        }


        private void AddTransparentTextBox()
        {
            TransparentTextBox transparentTextBox = new TransparentTextBox();
            transparentTextBox.Text = "";
            transparentTextBox.Location = new Point(10, 10);
            transparentTextBox.Size = new Size(200, 30);

            // Додаємо прозорий TextBox до контролу
            this.Controls.Add(transparentTextBox);
        }

        private void LoadCustomFont()
        {
            string resourcePath = "Fonts.DaysOne-Regular.ttf"; // Змініть на свій шлях
            using (Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
            {
                if (fontStream != null)
                {
                   
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        fontStream.CopyTo(memoryStream);
                        IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem((int)memoryStream.Length);
                        System.Runtime.InteropServices.Marshal.Copy(memoryStream.ToArray(), 0, fontPtr, (int)memoryStream.Length);
                        privateFonts.AddMemoryFont(fontPtr, (int)memoryStream.Length);
                        System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
                    }
                }
            }
        }

        public void Load()
        {

        }

        private void pidtverdityButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (mainForm != null)
            {
                // Перетворюємо текст у double та присвоюємо значення
                if (double.TryParse(transparentTextBox.Text, out double result))
                {
                    mainForm.isRakhunok = result;
                }
                else
                {
                    MessageBox.Show("Введено некоректне значення. Будь ласка, введіть число.");
                }
            }
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
