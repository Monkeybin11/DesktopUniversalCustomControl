﻿using DesktopUniversalCustomControl.CustomComponent;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DesktopUniversalCustomControl.Service.Common
{
    /// <summary>
    /// Double转Int
    /// </summary>
    public class DoubleToInt : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Math.Round((double)value, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TimeSpan.FromSeconds((double)value).ToString();
        }
    }

    /// <summary>
    /// Double转TimeSpan
    /// </summary>
    public class DoubleToTimeSpan : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TimeSpan.FromSeconds(Math.Round((double)value, 0));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// SelectedItem取值
    /// </summary>
    public class SelectedItemToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? string.Empty : value.ToString().Split(':')[1];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    /// <summary>
    /// CustomIconControl
    /// Canvas控件的显示与否
    /// </summary>
    public class CanvasNameToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kind = (IconType)value;
            string canvasName = parameter.ToString();
            if (canvasName.Contains(kind.ToString()))
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
