using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace DesktopUniversalCustomControl.Extensions
{
    public static class BrushExtensions
    {
        /// <summary>
        /// 16 进制转 Brush
        /// </summary>
        public static Brush ToBrush(this string hexadecimal) => (Brush)new BrushConverter().ConvertFromString(hexadecimal);
    }
}
