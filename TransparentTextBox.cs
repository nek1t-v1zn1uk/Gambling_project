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
        this.BorderStyle = BorderStyle.None; // Прибрали рамку для кращого вигляду
        this.TextAlign = HorizontalAlignment.Center; // Вирівнювання тексту по центру
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Пропускаємо малювання фону, щоб залишити прозорість
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        this.Invalidate(); // Перемальовуємо текстбокс, коли змінюється текст
    }
}