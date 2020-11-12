using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopUniversalCustomControl.CustomComponent
{
    /// <summary>
    /// CustomCheckBox
    /// </summary>
    [TemplatePart(Name = "PART_Border", Type = typeof(Border))]
    public class CustomCheckBox : CheckBox
    {
        private static Border border;
        private const double StandardSize = 20D;

        static CustomCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomCheckBox), new FrameworkPropertyMetadata(typeof(CustomCheckBox)));
        }


        public override void OnApplyTemplate()
        {
            border = GetTemplateChild("PART_Border") as Border;
            border.RenderTransform = ScaleTransformResult(CheckBoxSize);
            base.OnApplyTemplate();
        }

        public Brush IsMouseOverBackground
        {
            get { return (Brush)GetValue(IsMouseOverBackgroundProperty); }
            set { SetValue(IsMouseOverBackgroundProperty, value); }
        }
        public static readonly DependencyProperty IsMouseOverBackgroundProperty =
            DependencyProperty.Register("IsMouseOverBackground", typeof(Brush), typeof(CustomCheckBox), new PropertyMetadata(default(Brush)));


        public Brush FillBrush
        {
            get { return (Brush)GetValue(FillBrushProperty); }
            set { SetValue(FillBrushProperty, value); }
        }
        public static readonly DependencyProperty FillBrushProperty =
            DependencyProperty.Register("FillBrush", typeof(Brush), typeof(CustomCheckBox), new PropertyMetadata(default(Brush)));


        public FillType FillType
        {
            get { return (FillType)GetValue(FillTypeProperty); }
            set {  SetValue(FillTypeProperty, value); }
        }
        /// <summary>
        /// 填充类型(■，✔)
        /// </summary>
        public static readonly DependencyProperty FillTypeProperty =
            DependencyProperty.Register("FillType", typeof(FillType), typeof(CustomCheckBox), new PropertyMetadata(default(FillType)));


        public double CheckBoxSize
        {
            get { return (double)GetValue(CheckBoxSizeProperty); }
            set { SetValue(CheckBoxSizeProperty, value); }
        }
        /// <summary>
        ///  CheckBox的呈现大小
        /// <see cref="CheckBoxSize"/>
        /// </summary>
        public static readonly DependencyProperty CheckBoxSizeProperty =
            DependencyProperty.Register("CheckBoxSize", typeof(double), typeof(CustomCheckBox), new FrameworkPropertyMetadata(20D, new PropertyChangedCallback(CheckBoxSizeChanged)));
        private static void CheckBoxSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (border == null) return;
            border.RenderTransform = ScaleTransformResult((double)e.NewValue);
        }

        private static ScaleTransform ScaleTransformResult(double value)
        {
            ScaleTransform scaleTransform = new ScaleTransform();
            scaleTransform.ScaleX = value / StandardSize;
            scaleTransform.ScaleY = value / StandardSize;
            return scaleTransform;
        }
    }


    public enum FillType
    {
        Check,
        Rectangle,
    }
}
