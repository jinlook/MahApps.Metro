using System;
using System.Globalization;
using System.Windows.Data;
using MVVMApps.Metro.Controls;

namespace MVVMApps.Metro.Converters
{
    public class OffOnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var t = (ToggleSwitch)parameter;

            return t.IsChecked == true ? t.OnLabel : t.OffLabel;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}