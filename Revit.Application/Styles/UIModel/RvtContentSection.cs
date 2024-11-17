using System;
using System.Windows;
using System.Windows.Controls;

namespace Revit.Application.Styles.UIModel
{
    public class RvtContentSection : ContentControl
    {
        public object MainWindowHeader
        {
            get
            {
                return GetValue(MainWindowHeaderProperty);
            }
            set
            {
                SetValue(MainWindowHeaderProperty, value);
            }
        }

        public object MainWindowDescription
        {
            get
            {
                return GetValue(MainWindowDescriptionProperty);
            }
            set
            {
                SetValue(MainWindowDescriptionProperty, value);
            }
        }


        public Visibility MainWindowDescriptionVisibility
        {
            get
            {
                if (string.IsNullOrWhiteSpace(MainWindowDescription as string))
                {
                    return Visibility.Visible;
                }
                return Visibility.Collapsed;
            }
        }

        public static readonly DependencyProperty MainWindowHeaderProperty = DependencyProperty.Register("MainWindowHeader", typeof(object), typeof(RvtContentSection), new PropertyMetadata(null));

        public static readonly DependencyProperty MainWindowDescriptionProperty = DependencyProperty.Register("MainWindowDescription", typeof(object), typeof(RvtContentSection), new PropertyMetadata(null));

        public static readonly DependencyProperty MainWindowDescriptionVisibilityProperty = DependencyProperty.Register("MainWindowDescriptionVisibility", typeof(Visibility), typeof(RvtContentSection), new PropertyMetadata(null));
    }
}
