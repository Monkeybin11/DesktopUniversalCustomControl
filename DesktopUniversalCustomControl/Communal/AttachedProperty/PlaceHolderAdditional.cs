using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using DesktopUniversalCustomControl.Extensions;

namespace DesktopUniversalCustomControl.Communal.AttachedProperty
{
    public class PlaceHolderAdditional : DependencyObject
    {
        public static Brush GetPlaceHolderForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(PlaceHolderForegroundProperty);
        }
        public static void SetPlaceHolderForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(PlaceHolderForegroundProperty, value);
        }
        /// <summary>
        /// 占位提示语字体颜色
        /// <see cref="PlaceHolderForegroundProperty"/>
        /// </summary>
        public static readonly DependencyProperty PlaceHolderForegroundProperty =
            DependencyProperty.RegisterAttached("PlaceHolderForeground", typeof(Brush), typeof(PlaceHolderAdditional), new PropertyMetadata("#CACCCE".ToBrush()));
    }
}
