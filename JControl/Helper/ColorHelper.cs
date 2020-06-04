using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace JControl.Helper
{
    public static class ColorHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Color GetNearColor(Color color, float correctionFactor)
        {
            try
            {
                float red = (float)color.R;
                float green = (float)color.G;
                float blue = (float)color.B;

                if (correctionFactor < 0)
                {
                    correctionFactor = 1 + correctionFactor;
                    red *= correctionFactor;
                    green *= correctionFactor;
                    blue *= correctionFactor;
                }
                else
                {
                    red = (255 - red) * correctionFactor + red;
                    green = (255 - green) * correctionFactor + green;
                    blue = (255 - blue) * correctionFactor + blue;
                }

                if (red < 0) red = 0;

                if (red > 255) red = 255;

                if (green < 0) green = 0;

                if (green > 255) green = 255;

                if (blue < 0) blue = 0;

                if (blue > 255) blue = 255;



                return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
            }
            catch
            {
                return color;

            }
        

        }

    }
}
