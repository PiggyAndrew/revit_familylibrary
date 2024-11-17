using System.Windows;
using System.Windows.Controls;

namespace Revit.Application.Contants
{
    public class PasswordDependencyProperty
    {

        //注册附加属性，通过这个类直接调用给任意依赖对象
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordDependencyProperty),
                new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnPropertyChanged)));
        //传入事件的委托方法，当依赖属性修改时更新依赖属性的值      

        //依赖属性通过Get、Set方法获取,和界面的Password绑定
        public static string GetPassword(DependencyObject d)
        {
            return d.GetValue(PasswordProperty).ToString();
        }
        public static void SetPassword(DependencyObject d, string value)
        {
            d.SetValue(PasswordProperty, value);
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)d;
            //让每次修改都只更新一次依赖属性
            SetPassword(passwordBox, passwordBox.Password);
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            SetPassword(passwordBox, passwordBox.Password);
        }
    }
}
