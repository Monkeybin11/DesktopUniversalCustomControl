using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DesktopUniversalCustomControl.Communal.AttachedProperty
{
    public class CornerRadiusAdditional : DependencyObject
    {
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }
        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }
        /// <summary>
        /// 圆角度
        /// <see cref="CornerRadiusProperty"/>
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(CornerRadiusAdditional), new PropertyMetadata(new CornerRadius(2)));


    }
}
