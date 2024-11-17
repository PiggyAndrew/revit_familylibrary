using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Revit.Application.Styles.UIModel
{
    public class AutodeskTabControl : TabControl
    {
        public bool IsSideBarExpanded
        {
            get
            {
                return (bool)GetValue(IsSideBarExpandedProperty);
            }
            set
            {
                SetValue(IsSideBarExpandedProperty, value);
            }
        }

        public Brush ApplicationColor
        {
            get
            {
                return (Brush)GetValue(ApplicationColorProperty);
            }
            set
            {
                SetValue(ApplicationColorProperty, value);
            }
        }

        public Brush ApplicationColorHover
        {
            get
            {
                return (Brush)GetValue(ApplicationColorHoverProperty);
            }
            set
            {
                SetValue(ApplicationColorHoverProperty, value);
            }
        }

        public bool ShowSidebar
        {
            get
            {
                return (bool)GetValue(ShowSidebarProperty);
            }
            set
            {
                SetValue(ShowSidebarProperty, value);
            }
        }

        public double SidebarExpandedWidth
        {
            get
            {
                return (double)GetValue(SidebarExpandedWidthProperty);
            }
            set
            {
                SetValue(SidebarExpandedWidthProperty, value);
            }
        }

        public AutodeskTabControl()
        {
            SelectionChanged += AutodeskTabControl_SelectionChanged;
        }

        public bool WhiteActiveButtonText
        {
            get
            {
                return (bool)GetValue(WhiteActiveButtonTextProperty);
            }
            set
            {
                SetValue(WhiteActiveButtonTextProperty, value);
            }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new AutodeskTabItem();
        }

        private void AutodeskTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IsSideBarExpanded = false;
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            object originalSource = e.OriginalSource;
            DependencyObject dependencyObject = originalSource as DependencyObject;
            bool flag = dependencyObject != null && !IsSelfOrVisualChild(dependencyObject, "PART_Sidebar");
            if (flag)
            {
                IsSideBarExpanded = false;
            }
            base.OnPreviewMouseLeftButtonDown(e);
        }

        private bool IsSelfOrVisualChild(DependencyObject child, string parentName)
        {
            for (; ; )
            {
                string text;
                if (child == null)
                {
                    text = null;
                }
                else
                {
                    object value = child.GetValue(NameProperty);
                    text = value != null ? value.ToString() : null;
                }
                string a = text;
                bool flag = a == parentName;
                if (flag)
                {
                    break;
                }
                bool flag2 = child != null;
                if (flag2)
                {
                    child = child is Visual || child is Visual3D ? VisualTreeHelper.GetParent(child) : LogicalTreeHelper.GetParent(child);
                }
                if (child == null)
                {
                    goto Block_6;
                }
            }
            return true;
        Block_6:
            return false;
        }

        public static readonly DependencyProperty SidebarExpandedWidthProperty = DependencyProperty.Register("SidebarExpandedWidth", typeof(double), typeof(AutodeskTabControl), new PropertyMetadata(300.0));

        public static readonly DependencyProperty IsSideBarExpandedProperty = DependencyProperty.Register("IsSideBarExpanded", typeof(bool), typeof(AutodeskTabControl), new PropertyMetadata(false));

        public static readonly DependencyProperty ApplicationColorProperty = DependencyProperty.Register("ApplicationColor", typeof(Brush), typeof(AutodeskTabControl), new PropertyMetadata(new SolidColorBrush(Colors.Red)));

        public static readonly DependencyProperty ApplicationColorHoverProperty = DependencyProperty.Register("ApplicationColorHover", typeof(Brush), typeof(AutodeskTabControl), new PropertyMetadata(new SolidColorBrush(Colors.DeepPink)));

        public static readonly DependencyProperty ShowSidebarProperty = DependencyProperty.Register("ShowSidebar", typeof(bool), typeof(AutodeskTabControl), new PropertyMetadata(true));

        public static readonly DependencyProperty WhiteActiveButtonTextProperty = DependencyProperty.Register("WhiteActiveButtonText", typeof(bool), typeof(AutodeskTabControl), new PropertyMetadata(false));
    }
}
