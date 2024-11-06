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

            LoadCustomFont();
            AddTransparentTextBox();
            Load();
            

        }

        public void Load()
        {
            int x, y, p, w, h;
            w = (int)(Width / 4.266);
            h = (int)(w / 3.6);
            x = (int)((Width - w) / 2);
            y = (int)(Height / 4.39);
            p = (int)((Height - h * 4 - y * 2) / 3);

            pidtverdityPicture.Size = new Size(w, h);
            pidtverdityPicture.Location = new Point(x, y);

            // Розміщення pictureTextBox нижче pidtverdityPicture
            pictureTextBox.Size = new Size(w, h);
            pictureTextBox.Location = new Point(x, y + h + p);

            // Зменшення розміру transparentTextBox і опускання його нижче
            transparentTextBox.Size = new Size(w - 30, h - 30); // Зменшення розміру на 10 пікселів по обидва боки
            transparentTextBox.Location = new Point(x+10, y + h + p + 40); // Опустити на 10 пікселів нижче pictureTextBox

            // Розміщення pidtverdityButton під transparentTextBox
            pidtverdityButton.Size = new Size(w, h);
            pidtverdityButton.Location = new Point(x, y + (h * 2) + (p * 2) + 20);
        }


        private void LoadCustomFont()
        {
           string resourcePath = "Gambling.Fonts.DaysOne-Regular.ttf"; 
           using (Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
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
        private void AddTransparentTextBox()
        {
            
            transparentTextBox = new TransparentTextBox
            {
                Text = "",
                Location = new Point(10, 10),
                Size = new Size(200, 30),

                Font = new Font(privateFonts.Families[0], 20.0F, FontStyle.Regular),
                ForeColor = Color.FromArgb(46, 46, 46),
                BackColor = ColorTranslator.FromHtml("#f7f7f7"),
            };

            
            transparentTextBox.KeyPress += TransparentTextBox_KeyPress;

            this.Controls.Add(transparentTextBox);
            transparentTextBox.BringToFront();
        }


       

        private void pidtverdityButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (transparentTextBox.Text != "")
            {
                mainForm.isRakhunok += int.Parse(transparentTextBox.Text);
                transparentTextBox.Text = "";
            }
            else return;

        }
        private void TransparentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
            UserControl_KeyPress(sender, e);
        }

        private void pidtverdityButton_MouseDown(object sender, MouseEventArgs e)
        {
            pidtverdityButton.BackgroundImage = Properties.Resources.pidtverdity_clicked;
        }

        private void pidtverdityButton_MouseEnter(object sender, EventArgs e)
        {
            pidtverdityButton.BackgroundImage = Properties.Resources.pidtverdity_hovered;
        }

        private void pidtverdityButton_MouseLeave(object sender, EventArgs e)
        {
            pidtverdityButton.BackgroundImage = Properties.Resources.pidtverdity;
        }

        private void pidtverdityButton_MouseUp(object sender, MouseEventArgs e)
        {
            pidtverdityButton.BackgroundImage = Properties.Resources.pidtverdity;
        }

        private void UserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                pidtverdityButton_MouseClick(null, null);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                mainForm.backButton_MouseClick(null, null);
            }
        }

    }
}
