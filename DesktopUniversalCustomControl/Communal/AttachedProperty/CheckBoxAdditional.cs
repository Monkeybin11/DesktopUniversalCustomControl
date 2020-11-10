using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DesktopUniversalCustomControl.CustomComponent;

namespace DesktopUniversalCustomControl.Communal.AttachedProperty
{

    public class CheckBoxAdditional : DependencyObject
    {
        private const double StandardSize = 20D;

        public static double GetCheckBoxSize(DependencyObject obj)
        {
            return (double)obj.GetValue(CheckBoxSizeProperty);
        }

        public static void SetCheckBoxSize(DependencyObject obj, double value)
        {
            obj.SetValue(CheckBoxSizeProperty, value);
        }

        /// <summary>
        ///  CheckBox的呈现大小
        /// <see cref="CheckBoxSizeProperty"/>
        /// </summary>
        public static readonly DependencyProperty CheckBoxSizeProperty =
            DependencyProperty.RegisterAttached("CheckBoxSize", typeof(double), typeof(CheckBoxAdditional), new PropertyMetadata(20.0, new PropertyChangedCallback(CheckBoxSizeChanged)));

        private static void CheckBoxSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var customCheckBox = d as CustomCheckBox;

            customCheckBox.Loaded += delegate { ScaledTransformResult(customCheckBox, e); };

            if(customCheckBox.IsLoaded)
                ScaledTransformResult(customCheckBox, e);
        }

        private static void ScaledTransformResult(CustomCheckBox customCheckBox, DependencyPropertyChangedEventArgs e)
        {
            var border = customCheckBox.Template?.FindName("PART_Border", customCheckBox) as Border;
            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = (double)e.NewValue / StandardSize;
            scaleTransform.ScaleY = (double)e.NewValue / StandardSize;
            border.RenderTransform = scaleTransform;
        }
    }
}
