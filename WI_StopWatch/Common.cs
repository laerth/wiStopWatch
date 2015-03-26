using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace WI_StopWatch
{
    public static class Common
    {
        public static void ResizeButtonImg(Button btn, float scale)
        {
            if (btn.BackgroundImage != null)
            {
                Bitmap newImage = new Bitmap((int)(btn.Width * scale), (int)(btn.Height * scale));
                using (Graphics g = Graphics.FromImage(newImage))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    g.DrawImage(btn.BackgroundImage, new Rectangle(0, 0, newImage.Width, newImage.Height));
                }

                btn.BackgroundImage = newImage;
                btn.BackgroundImageLayout = ImageLayout.Center;
            }
        }

        public static void SetHint(Control control, string hint)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(control, hint);
        }
    }
}
