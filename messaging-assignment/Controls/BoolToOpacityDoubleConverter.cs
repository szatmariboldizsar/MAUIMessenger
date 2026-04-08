using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace messaging_assignment.Controls
{
    public class BoolToOpacityDoubleConverter : IValueConverter
    {
        // Converts Boolean to Double (for Opacity)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isOpaque)
            {
                return isOpaque ? 1.0 : 0.0;
            }
            return 0.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
