using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TestApp
{
    [ValueConversion(typeof(float), typeof(string))]
    class StringToFloatConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return ((float)value).ToString("N3");
            else
                return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrEmpty(value?.ToString()))
                return float.Parse(value.ToString(), NumberStyles.Float);
            else
                return 0.0;
        }
    }
}
