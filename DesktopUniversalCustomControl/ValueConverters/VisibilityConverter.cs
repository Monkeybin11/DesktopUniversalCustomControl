using DesktopUniversalCustomControl.CustomComponent;
using DesktopUniversalCustomControl.CustomView.MsgDlg;
using DesktopUniversalCustomControl.Extensions.BaseCategory;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace DesktopUniversalCustomControl.ValueConverters
{
    public class MessageDialogButtonToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var count = (MessageButtonCount)value;
            if (count.ToString().Contains(parameter.ToString())) //注意大小写，不然要会找不到界面报错
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    [MarkupExtensionReturnType(typeof(Visibility))]
    public class BooleanTrueToVisibilityConverter : MarkupExtensionBase, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolBox = (bool)value;
            return boolBox == true ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    [MarkupExtensionReturnType(typeof(Visibility))]
    public class BooleanFalseToVisibilityConverter : MarkupExtensionBase, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolBox = (bool)value;
            return boolBox == false ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    [MarkupExtensionReturnType(typeof(Visibility))]
    public class MediaPlayerStateToVisibility : MarkupExtensionBase, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (MediaPlayerState)value == MediaPlayerState.Pause ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    [MarkupExtensionReturnType(typeof(Visibility))]
    public class ChartTypeToVisibility : MarkupExtensionBase, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ChartType type = (ChartType)value;
            if (parameter.ToString().Contains(type.ToString()))
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
