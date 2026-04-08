using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MAUIMessenger.Controls
{
    public class ReadConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? "Mark as Unread" : "Mark as Read";

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
