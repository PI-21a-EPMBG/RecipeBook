using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RecipeBookWF
{
    public class FontSizeConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double height = (double)values[0];
            double width = (double)values[1];
            double value = Double.Parse((string)values[2]);

            // Используем простую формулу для определения размера шрифта
            return Math.Min(height / value, width / value);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
