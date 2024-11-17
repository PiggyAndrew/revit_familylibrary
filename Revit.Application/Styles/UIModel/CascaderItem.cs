using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Revit.Application.Styles.UIModel
{
    public class CascaderItem : Control
    {
        private StackPanel panel;

        /// <summary>
        /// 内容资源
        /// </summary>
        public IEnumerable<object> ItemsSource
        {
            get { return (IEnumerable<object>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable<object>), typeof(CascaderItem), new PropertyMetadata(null));



        public object SelectedItem
        {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(CascaderItem), new PropertyMetadata(default(object)));

        public CascaderInnerList SelectedView
        {
            get { return (CascaderInnerList)GetValue(SelectedViewProperty); }
            set { SetValue(SelectedViewProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedViewProperty =
            DependencyProperty.Register("SelectedView", typeof(CascaderInnerList), typeof(CascaderItem), new PropertyMetadata(null));


        public bool IsMultipleChoose
        {
            get { return (bool)GetValue(IsMultipleChooseProperty); }
            set { SetValue(IsMultipleChooseProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsMultipleChoose.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsMultipleChooseProperty =
            DependencyProperty.Register("IsMultipleChoose", typeof(bool), typeof(CascaderItem), new PropertyMetadata(default(bool), OnIsMultipleChooseChanged));

        private static void OnIsMultipleChooseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CascaderItem cascaderItem)
            {
                if (cascaderItem.panel != null && cascaderItem.Count > 0)
                {
                    foreach (var item in cascaderItem.panel.Children)
                    {
                        if (item is CascaderInnerList cascaderInner)
                        {
                            cascaderInner.IsMultipleChoose = (bool)e.NewValue;
                        }
                        else if (item is StackPanel stack)
                        {
                            CascaderInnerList innerList = stack.Children[1] as CascaderInnerList;
                            innerList.IsMultipleChoose = (bool)e.NewValue;
                        }
                    }
                }
            }
        }
        private int Count { get { return panel.Children.Count; } }



        public CascaderItem()
        {
            Loaded += CascaderItem_Loaded;
            Unloaded += CascaderItem_Unloaded;
        }

        private void CascaderItem_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            panel = GetTemplateChild("sp_path") as StackPanel;

        }

        public event EventHandler SelectedChanged;

        private void CascaderItem_Loaded(object sender, RoutedEventArgs e)
        {
            if (ItemsSource != null && panel != null && panel.Children.Count == 0)
            {
                CascaderInnerList cascaderInner = new CascaderInnerList();
                cascaderInner.ItemsSource = ItemsSource;
                cascaderInner.DeepIndex = 0;
                cascaderInner.IsMultipleChoose = IsMultipleChoose;
                cascaderInner.SelectionChanged += ListBox_SelectionChanged;
                panel.Children.Add(cascaderInner);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is CascaderInnerList inner)
            {
                ListBox listBox = inner.innerListBox;
                SelectedItem = listBox.SelectedItem;

                //还要再次反射 看是不是最后一层
                //通过反射获取数据
                if (!IsMultipleChoose)
                {
                    var innerGetType = listBox.SelectedItem.GetType().GetProperty("Children");
                    if (innerGetType != null)
                    {
                        object innerContent = innerGetType.GetValue(listBox.SelectedItem, null);
                        if (innerContent == null)
                        {
                            SelectedView = inner;
                            //是最后一层了 通过事件通知出去
                            SelectedChanged?.Invoke(this, EventArgs.Empty);
                        }
                    }
                }
                else
                {
                    SelectedView = inner;
                    //勾选便通知
                    SelectedChanged?.Invoke(this, EventArgs.Empty);
                }

                //通过层级关系 判断是否清空之前的数据
                if (Count > inner.DeepIndex + 1)
                {
                    panel.Children.RemoveRange(inner.DeepIndex + 1, panel.Children.Count - 1);
                }

                if (listBox.SelectedItem != null)
                {
                    var obj = listBox.SelectedItem;
                    //通过反射获取数据
                    var getType = obj.GetType().GetProperty("Children");
                    if (getType != null)
                    {
                        object content = getType.GetValue(obj, null);

                        if (content != null && content is IEnumerable<object> itemSource)
                        { //判断是否存在子对象 也就是下级菜单
                            //存在开始拼接下级菜单
                            //添加分割线

                            //添加一个容器 好用于计算层数
                            StackPanel st = new StackPanel();
                            st.Orientation = Orientation.Horizontal;
                            //st.VerticalAlignment = VerticalAlignment.Center;
                            Border border = new Border();
                            border.Width = 1;
                            border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e4e7ed"));
                            st.Children.Add(border);
                            //添加子集菜单
                            CascaderInnerList cascaderInner = new CascaderInnerList();
                            cascaderInner.ItemsSource = itemSource;
                            cascaderInner.DeepIndex = inner.DeepIndex + 1;
                            cascaderInner.ParentSource = inner;
                            cascaderInner.IsMultipleChoose = IsMultipleChoose;
                            //cascaderInner.SetValue(Extensions.CascaderExtensions.MultipleChoiceProperty, false);

                            cascaderInner.SelectionChanged += ListBox_SelectionChanged;
                            st.Children.Add(cascaderInner);

                            panel.Children.Add(st);

                        }
                    }
                }
            }
        }
    }


}
