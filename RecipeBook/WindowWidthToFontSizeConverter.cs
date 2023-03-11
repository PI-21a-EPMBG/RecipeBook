using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RecipeBook
{
    public class WindowSizeToFontSizeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double width = (double)values[0];
            double height = (double)values[1];

            // Выбираем минимальное значение между шириной и высотой окна
            double size = Math.Min(width, height) / 50;

            return size;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
