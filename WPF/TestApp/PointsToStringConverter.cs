using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace TestApp
{
    [ValueConversion(typeof(Point[]), typeof(string))]
    class PointsToStringConverter : IValueConverter
    {
        public object Convert(object pointVal, Type targetType, object parameter, CultureInfo culture)
        {
            string str = "";
            if(pointVal != null)
            {
                Point[] points = ((Point[])pointVal);
                foreach(var p in points)
                {
                    str += $"({Math.Round(p.X)} ; {Math.Round(p.Y)}) ";
                }
                str = str.Remove(str.Length - 1);
            }
            return str;
        }

        public object ConvertBack(object strVal, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string[] sourse = strVal.ToString().Split(' ');
                sourse = sourse.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                int indx = 0;
                var points = new Point[sourse.Length];
                for (int i = 0; i < sourse.Length; i++) 
                {
                    sourse[i] = sourse[i].Trim('(', ')');
                    string[] pointStr = sourse[i].Split(';');
                    points[indx].X = float.Parse(pointStr[0]);
                    points[indx].Y = float.Parse(pointStr[1]);
                    ++indx;
                }
                return points;
            }
            catch(Exception ex)
            {
                return DependencyProperty.UnsetValue;
            }
        }
    }
}
