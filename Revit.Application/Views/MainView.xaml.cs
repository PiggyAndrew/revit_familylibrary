using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Prism.Ioc;
using Revit.Application.ViewModels;
using Prism.Regions;

namespace Revit.Application.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView:Window
    {
        public MainView()
        {
            InitializeComponent();

            BtnMin.Click += BtnMin_Click;
            BtnMax.Click += BtnMax_Click;
            BtnClose.Click += BtnClose_Click;

            toggleMenuButton.Click += BtnDoubleLeft_Click; ;
        }

        private void BtnDoubleLeft_Click(object sender, RoutedEventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (StackHeader.Visibility == Visibility.Visible)
            {
                StackHeader.Visibility = Visibility.Collapsed;
                GridLeftMenu.Width = new GridLength(75);
            }
            else
            {
                StackHeader.Visibility = Visibility.Visible;
                GridLeftMenu.Width = new GridLength(235);
            }
        }

        private async void BtnClose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //if (await dialog.Question(Local.Localize("AreYouSure")))
            //    appStartService.Exit();
            this.Close();   
        }

        private void BtnMax_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SetWindowState();
        }

        private void BtnMin_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WindowState = ((base.WindowState != System.Windows.WindowState.Minimized) ?
                System.Windows.WindowState.Minimized : System.Windows.WindowState.Normal);
        }


        private void SetWindowState()
        {
            this.WindowState = ((base.WindowState != System.Windows.WindowState.Maximized) ? System.Windows.WindowState.Maximized : System.Windows.WindowState.Normal);
        }

        //private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        //{
        //    if (e.OriginalSource != null && e.OriginalSource is TabCloseItem tabItem)
        //    {
        //        if (this.DataContext is MainTabsViewModel viewModel)
        //            viewModel.NavigationService.RemoveView(tabItem.Content);
        //    }
        //}

    }
}
