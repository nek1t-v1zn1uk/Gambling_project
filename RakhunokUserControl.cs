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
            LoadCustomFont();
            AddTransparentTextBox();
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
                Font = new Font(privateFonts.Families[0], 48.0F, FontStyle.Regular),
                ForeColor = Color.FromArgb(46, 46, 46),
            };

            
            transparentTextBox.KeyPress += TransparentTextBox_KeyPress;

            this.Controls.Add(transparentTextBox);
        }


        public void Load()
        {

        }

        private void pidtverdityButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (transparentTextBox.Text != "")
                mainForm.isRakhunok = double.Parse(transparentTextBox.Text);
            else return;

        }
        private void TransparentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

           
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != decimalSeparator && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
            
            if (e.KeyChar == decimalSeparator && transparentTextBox.Text.Contains(decimalSeparator.ToString()))
            {
                e.Handled = true; 
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
