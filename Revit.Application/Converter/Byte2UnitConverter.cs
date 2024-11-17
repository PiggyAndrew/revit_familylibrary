using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Revit.Application.Converter
{
    public class Byte2UnitConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is long fileSize)
            {
               
                 if (fileSize < 1024 * 1024 * 1024) // 小于 1 GB
                {
                    double sizeInMB = fileSize / (1024.0 * 1024.0);
                    return $"{sizeInMB:F2} MB";
                }
                else // 大于等于 1 GB
                {
                    double sizeInGB = fileSize / (1024.0 * 1024.0 * 1024.0);
                    return $"{sizeInGB:F2} GB";
                }
            }
            return "Unknown";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
