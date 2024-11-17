using Revit.Application.Styles.UIModel;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Animation;

namespace Revit.Application.Styles.Converter
{
    public class StoryboardConverter : IMultiValueConverter
    {
        public Storyboard Storyboard { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            object obj = values[0];
            if (!(obj is AutodeskTabItem autodeskTabItem))
            {
                throw new InvalidCastException("First value could not be converted to AutodeskTabItem");
            }
            if (!(values[1] is bool flag) || 1 == 0)
            {
                throw new InvalidCastException("Second value could not be converted to a bool value");
            }
            if (flag)
            {
                Storyboard.Stop(autodeskTabItem);
                Storyboard.Remove(autodeskTabItem);
                autodeskTabItem.Expanded = true;
            }
            else
            {
                Storyboard.Begin(autodeskTabItem, isControllable: true);
            }
            return true;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
