using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentTextBox : TextBox
{
    public TransparentTextBox()
    {
        // Увімкнення підтримки прозорого фону
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.Transparent; // Прозорий фон
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Пропускаємо малювання фону, щоб залишити прозорість
    }
}
