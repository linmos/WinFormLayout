using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormLayout
{
    public class ExtendToolStrip : ToolStrip
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect,
                                                                              Color.FromArgb(255, 255, 255),
                                                                              Color.FromArgb(214, 214, 214),
                                                                              LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(linearGradientBrush, rect);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromArgb(240, 240, 240), 4), 0, 0, this.Width, 0);
            //e.Graphics.DrawLine(new Pen(Color.FromArgb(130, 135, 144), 2), 0, this.Height, this.Width, this.Height);
            
            if (this.RenderMode == ToolStripRenderMode.System)
            {
                // remove bottom border in system mode
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height - 2);
                e.Graphics.SetClip(rect);
            }
            
            base.OnPaint(e);
        }
    }
}
