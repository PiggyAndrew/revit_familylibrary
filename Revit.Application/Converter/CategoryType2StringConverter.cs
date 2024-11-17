using Revit.Shared.Entity.Family;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Revit.Application.Converter
{
    public class CategoryType2StringConverter : IValueConverter
    {
        private string _elementType = "元素类型";
        private string _keyword = "关键词";
        private string _major = "专业";
        private string _producer = "生产厂家";
        private string _property = "属性";
        private string _software = "软件";


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CategoryType status)
            {
                switch (status)
                {
                    case CategoryType.ElementType: return _elementType;
                    case CategoryType.Keyword: return _keyword;
                    case CategoryType.Major: return _major;
                    case CategoryType.Producer: return _producer;
                    case CategoryType.Property: return _property;
                    case CategoryType.Software: return _software;
                    default:
                        break;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string strValue)
            {
                if (strValue == _elementType) return CategoryType.ElementType;
                if (strValue == _keyword) return CategoryType.Keyword;
                if (strValue == _major) return CategoryType.Major;
                if (strValue == _producer) return CategoryType.Producer;
                if (strValue == _property) return CategoryType.Property;
                if (strValue == _software) return CategoryType.Software;
            }
            return value;
        }
    }
}
