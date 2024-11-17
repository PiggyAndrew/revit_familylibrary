using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Revit.Application.Styles.UIModel
{
    public class CascadePicker : Control
    {
        private List<string> nameList = new List<string>();
        private List<object> objList = new List<object>();

        /// <summary>
        /// 是否下拉展开
        /// </summary>
        public bool IsDropDown
        {
            get { return (bool)GetValue(IsDropDownProperty); }
            set { SetValue(IsDropDownProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsDropDown.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsDropDownProperty =
            DependencyProperty.Register("IsDropDown", typeof(bool), typeof(CascadePicker), new PropertyMetadata(default(bool)));

        public string SelectedNamePath
        {
            get { return (string)GetValue(SelectedNamePathProperty); }
            set { SetValue(SelectedNamePathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedNamePath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedNamePathProperty =
            DependencyProperty.Register("SelectedNamePath", typeof(string), typeof(CascadePicker), new PropertyMetadata(default(string)));

        public List<object> SelectedValues
        {
            get { return (List<object>)GetValue(SelectedValuesProperty); }
            set { SetValue(SelectedValuesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedValues.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedValuesProperty =
            DependencyProperty.Register("SelectedValues", typeof(List<object>), typeof(CascadePicker), new PropertyMetadata(null));

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CascadePicker), new PropertyMetadata(default(CornerRadius)));

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
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable<object>), typeof(CascadePicker), new PropertyMetadata(null));

        public object SelectedItem
        {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(CascadePicker), new PropertyMetadata(default(object)));

        public bool IsMultipleChoose
        {
            get { return (bool)GetValue(IsMultipleChooseProperty); }
            set { SetValue(IsMultipleChooseProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsMultipleChoose.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsMultipleChooseProperty =
            DependencyProperty.Register("IsMultipleChoose", typeof(bool), typeof(CascadePicker), new PropertyMetadata(default(bool), OnIsMultipleChooseChanged));

        public bool IsLastDisplay
        {
            get { return (bool)GetValue(IsLastDisplayProperty); }
            set { SetValue(IsLastDisplayProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsLastDisplay.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLastDisplayProperty =
            DependencyProperty.Register("IsLastDisplay", typeof(bool), typeof(CascadePicker), new PropertyMetadata(default(bool)));

        private static void OnIsMultipleChooseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CascadePicker cascader)
            {
                if (cascader.cascaderItem != null)
                {
                    cascader.cascaderItem.IsMultipleChoose = (bool)e.NewValue;
                }
            }
        }

        private CascaderItem cascaderItem;
        private TextBlock textBlock;
        private Button showCleanButton;
        private Border bd1;

        public event EventHandler SelectedChanged;

        public CascadePicker()
        {

        }

        private void CascaderItem_SelectedChanged(object sender, EventArgs e)
        {
            nameList.Clear();
            objList.Clear();
            if (!IsMultipleChoose)
            {
                SelectedItem = cascaderItem.SelectedItem;

                if (SelectedItem != null)
                {
                    if (IsLastDisplay)
                    {
                        var nameProperty = SelectedItem.GetType().GetProperty("Name");
                        if (nameProperty != null)
                        {
                            object nameValue = nameProperty.GetValue(SelectedItem, null);
                            if (nameValue != null)
                            {
                                SelectedNamePath = nameValue.ToString();
                            }
                        }
                    }
                    else
                    {
                        Recursion(cascaderItem.SelectedView);
                        nameList.Reverse();
                        objList.Reverse();
                        SelectedValues = objList;
                        SelectedNamePath = string.Join("/", nameList);
                        IsDropDown = false;
                        SelectedChanged?.Invoke(this, e);
                    }
                }
            }
            else
            {
                if (ItemsSource != null && ItemsSource is IEnumerable<object> list)
                {
                    //递归获取所有最后一级的选中状态
                    string str = "";
                    GetChildrenStates(list, str);
                    if (nameList.Count > 0)
                    {
                        SelectedNamePath = string.Join(",", nameList);
                    }
                    else
                    {
                        SelectedNamePath = null;
                    }

                }
            }
            textBlock.Text = SelectedNamePath?.ToString();

        }
        void GetChildrenStates(IEnumerable<object> array, string str)
        {
            foreach (var item in array)
            {
                if (!IsLastDisplay)
                {
                    var mianSelectProperty = item.GetType().GetProperty("IsSelected");
                    if (mianSelectProperty != null)
                    {
                        var mainSelectValue = mianSelectProperty.GetValue(item, null);
                        if (mainSelectValue == null || (bool?)mainSelectValue == true)
                        {
                            var mainNameProperty = item.GetType().GetProperty("Name");
                            if (mainNameProperty != null)
                            {
                                var mainNameValue = mainNameProperty.GetValue(item, null);
                                if (mainNameValue != null)
                                {
                                    str += mainNameValue.ToString() + "/";
                                }
                            }
                        }
                    }

                }

                var childrenProperty = item.GetType().GetProperty("Children");
                if (childrenProperty != null)
                {
                    object childrenValue = childrenProperty.GetValue(item, null);
                    if (childrenValue != null && childrenValue is IEnumerable<object> innerArray&&innerArray.Any())
                    {
                        GetChildrenStates(innerArray, str);
                    }
                    else
                    {
                        //最后一层
                        //判断最后一层是否已经勾选
                        var selectProperty = item.GetType().GetProperty("IsSelected");
                        if (selectProperty != null)
                        {
                            var selectValue = selectProperty.GetValue(item, null);
                            if ((bool?)selectValue == true)
                            {
                                //名字
                                var nameProperty = item.GetType().GetProperty("Name");
                                if (nameProperty != null)
                                {
                                    var nameVaule = nameProperty.GetValue(item, null);
                                    if (!IsLastDisplay)
                                    {
                                        str += nameVaule?.ToString();
                                        nameList.Add(str);
                                    }
                                    else
                                    {
                                        nameList.Add(nameVaule?.ToString());
                                    }

                                }
                                //对象
                                objList.Add(item);
                            }
                        }
                    }
                }
            }
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            cascaderItem = GetTemplateChild("cascaderItem") as CascaderItem;
            textBlock = GetTemplateChild("textBlock") as TextBlock;
            showCleanButton = GetTemplateChild("showCleanButton") as Button;
            bd1 = GetTemplateChild("bd1") as Border;
            if (cascaderItem != null)
            {
                cascaderItem.SelectedChanged += CascaderItem_SelectedChanged;
            }
            if (showCleanButton != null)
            {
                showCleanButton.Click += ShowCleanButton_Click;
            }
            if (bd1 != null)
            {
                bd1.MouseLeftButtonDown += OnMouseLeftButtonDown;
            }
        }

        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            IsDropDown = !IsDropDown;
        }

        private void ShowCleanButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedValues = null; SelectedNamePath = null; SelectedItem = null; textBlock.Text = null; IsDropDown = false;
        }

        /// <summary>
        /// 递归计算所有的节点
        /// </summary>
        private void Recursion(CascaderInnerList innerObj)
        {
            if (innerObj != null && innerObj.SelectedItem != null)
            {


                var nameProperty = innerObj.SelectedItem.GetType().GetProperty("Name");
                if (nameProperty != null)
                {
                    object nameValue = nameProperty.GetValue(innerObj.SelectedItem, null);
                    if (nameValue != null)
                    {
                        nameList.Add(nameValue.ToString());
                        objList.Add(innerObj.SelectedItem);
                    }
                    //查看父级对象
                    if (innerObj.ParentSource != null)
                    {
                        Recursion(innerObj.ParentSource);
                    }

                }
            }
        }

    }


}
