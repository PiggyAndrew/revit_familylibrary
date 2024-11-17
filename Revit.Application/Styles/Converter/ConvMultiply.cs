using System;
using System.Globalization;
using System.Windows.Data;

namespace Revit.Application.Styles.Converter
{
    public class ConvMultiply : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double num = 1.0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] is double num2)
                {
                    num *= num2;
                }
            }
            return num;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
