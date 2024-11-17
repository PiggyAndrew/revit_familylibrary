using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Revit.Application.Styles.UIModel
{
    public class CascaderInnerList : Control
    {
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
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable<object>), typeof(CascaderInnerList), new PropertyMetadata(null));



        public object SelectedItem
        {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(CascaderInnerList), new PropertyMetadata(default(object)));

        public bool IsMultipleChoose
        {
            get { return (bool)GetValue(IsMultipleChooseProperty); }
            set { SetValue(IsMultipleChooseProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsMultipleChoose.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsMultipleChooseProperty =
            DependencyProperty.Register("IsMultipleChoose", typeof(bool), typeof(CascaderInnerList), new PropertyMetadata(default(bool)));




        public static ICommand ClickCommand { get; private set; }

        public ListBox innerListBox;

        public event SelectionChangedEventHandler SelectionChanged;
        /// <summary>
        /// 深度
        /// </summary>
        public int DeepIndex { get; set; }

        public CascaderInnerList ParentSource { get; set; }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            innerListBox = GetTemplateChild("listBox") as ListBox;
            innerListBox.SelectionChanged += (e, s) => {
                SelectedItem = innerListBox.SelectedItem;
                SelectionChanged?.Invoke(this, s);
            };
        }

        public CascaderInnerList()
        {
            Loaded += CascaderInnerList_Loaded;
            ClickCommand = new RelayCommand<object>(ClickCommandExecute);

        }
        private void CascaderInnerList_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void ClickCommandExecute(object obj)
        {
            if (obj != null && obj is CheckBox box)
            {
                var checkState = box.IsChecked;

                var data = box.DataContext;
                innerListBox.SelectedItem = data;

                //设置子对象状态
                SetChildrenState(checkState, data);

                //设置父对象状态
                SetParentState(checkState, this);

                SelectionChanged?.Invoke(this, null);
            }
        }

        private void SetParentState(bool? checkState, CascaderInnerList innerObj)
        {
            //获取父对象状态
            if (innerObj.ItemsSource != null && innerObj.ItemsSource is IEnumerable<object> array)
            {
                List<bool?> selectValues = new List<bool?>();
                foreach (object item in array)
                {
                    var selectedProperty = item.GetType().GetProperty("IsSelected");
                    if (selectedProperty != null)
                    {
                        var selectValue = selectedProperty.GetValue(item, null) as bool?;
                        selectValues.Add(selectValue);
                    }
                }
                if (selectValues.Count(x => x == true) == array.Count())
                {
                    checkState = true;
                }
                else if (selectValues.Count(x => x == false) == array.Count())
                {
                    checkState = false;
                }
                else
                {
                    checkState = null;
                }
            }

            if (innerObj.ParentSource != null && innerObj.ParentSource.SelectedItem != null)
            {

                var selectedProperty = innerObj.ParentSource.SelectedItem.GetType().GetProperty("IsSelected");
                if (selectedProperty != null)
                {
                    selectedProperty.SetValue(innerObj.ParentSource.SelectedItem, checkState);
                    //查看父级对象
                    if (innerObj.ParentSource != null)
                    {
                        SetParentState(checkState, innerObj.ParentSource);
                    }
                }
            }
        }

        void SetChildrenState(bool? state, object data)
        {

            var childrenProperty = data.GetType().GetProperty("Children");
            if (childrenProperty != null)
            {
                object childrenValue = childrenProperty.GetValue(data, null);
                if (childrenValue != null && childrenValue is IEnumerable<object> array)
                {
                    foreach (object item in array)
                    {
                        var selectedProperty = item.GetType().GetProperty("IsSelected");
                        if (selectedProperty != null)
                        {
                            selectedProperty.SetValue(item, state);
                            SetChildrenState(state, item);
                        }
                    }
                }
            }
        }
    }


}
