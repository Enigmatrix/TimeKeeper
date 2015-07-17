using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TimeKeeper.Converters
{
    public class BooleanToVisibilityConverter : DependencyObject, IValueConverter
    {
        public static DependencyProperty FlipProperty = DependencyProperty.Register("Flip", typeof (bool),
            typeof (BooleanToVisibilityConverter), new FrameworkPropertyMetadata(false));

        public bool Flip
        {
            get { return (bool) GetValue(FlipProperty); }
            set { SetValue(FlipProperty, value); }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var flag = false;
            if (value is bool)
                flag = (bool) value;
            if (!Flip)
                return flag ? Visibility.Visible : Visibility.Collapsed;
            return flag ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //No need to bother using this
            throw new NotImplementedException();
        }
    }
}