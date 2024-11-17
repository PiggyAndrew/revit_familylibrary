using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Revit.Application.Styles.UIModel
{
    public class AutodeskTabItem : TabItem
    {

        public bool StoryboardTargetProperty
        {
            get
            {
                return (bool)GetValue(StoryboardTargetPropertyProperty);
            }
            set
            {
                SetValue(StoryboardTargetPropertyProperty, value);
            }
        }

        public ImageSource IconActive
        {
            get
            {
                return (ImageSource)GetValue(IconActiveProperty);
            }
            set
            {
                SetValue(IconActiveProperty, value);
            }
        }

        public ImageSource IconInactive
        {
            get
            {
                return (ImageSource)GetValue(IconInactiveProperty);
            }
            set
            {
                SetValue(IconInactiveProperty, value);
            }
        }

        public ImageSource IconDisabled
        {
            get
            {
                return (ImageSource)GetValue(IconDisabledProperty);
            }
            set
            {
                SetValue(IconDisabledProperty, value);
            }
        }

        public Brush SelectedColor
        {
            get
            {
                return (Brush)GetValue(SelectedColorProperty);
            }
            set
            {
                SetValue(SelectedColorProperty, value);
            }
        }

        public bool Expanded
        {
            get
            {
                return (bool)GetValue(ExpandedProperty);
            }
            set
            {
                SetValue(ExpandedProperty, value);
            }
        }

        public static readonly DependencyProperty IconActiveProperty = DependencyProperty.Register("IconActive", typeof(ImageSource), typeof(AutodeskTabItem), new PropertyMetadata(null));

        public static readonly DependencyProperty IconInactiveProperty = DependencyProperty.Register("IconInactive", typeof(ImageSource), typeof(AutodeskTabItem), new PropertyMetadata(null));

        public static readonly DependencyProperty SelectedColorProperty = DependencyProperty.Register("SelectedColor", typeof(Brush), typeof(AutodeskTabItem), new PropertyMetadata(new SolidColorBrush(Colors.Red)));

        public static readonly DependencyProperty ExpandedProperty = DependencyProperty.Register("Expanded", typeof(bool), typeof(AutodeskTabItem), new PropertyMetadata(false));

        public static readonly DependencyProperty StoryboardTargetPropertyProperty = DependencyProperty.Register("StoryboardTargetProperty", typeof(bool), typeof(AutodeskTabItem), new PropertyMetadata(false));

        public static readonly DependencyProperty IconDisabledProperty = DependencyProperty.Register("IconDisabled", typeof(ImageSource), typeof(AutodeskTabItem), new PropertyMetadata(null));
    }
}
