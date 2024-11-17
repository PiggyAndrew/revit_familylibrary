using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Prism.Common;
using Prism.Ioc;
using Prism.Services.Dialogs;
using Revit.Shared;

namespace Revit.Shared.Prism
{
    /// <summary>
    /// Implements <see cref="IDialogService"/> to show modal and non-modal dialogs.
    /// </summary>
    /// <remarks>
    /// The dialog's ViewModel must implement IDialogAware.
    /// </remarks>
    public class DialogService : IDialogService
    {
        private readonly IContainerExtension _containerExtension;

        public DialogService(IContainerExtension containerExtension)
        {
            _containerExtension = containerExtension;
        }

        public void Show(string name, IDialogParameters parameters, Action<IDialogResult> callback)
        {
            ShowDialogInternal(name, parameters, callback, isModal: false);
        }

        public void ShowDialog(string name, IDialogParameters parameters, Action<IDialogResult> callback)
        {
            ShowDialogInternal(name, parameters, callback, isModal: true);
        }

        private void ShowDialogInternal(string name, IDialogParameters parameters, Action<IDialogResult> callback, bool isModal)
        {
            IDialogWindow dialogWindow = CreateDialogWindow();
            ConfigureDialogWindowEvents(dialogWindow, callback);
            ConfigureDialogWindowContent(name, dialogWindow, parameters);
            if (isModal)
            {
                dialogWindow.ShowDialog();
            }
            else
            {
                dialogWindow.Show();
            }
        }

        private IDialogWindow CreateDialogWindow()
        {
            return _containerExtension.Resolve<IDialogWindow>();
        }

        private void ConfigureDialogWindowContent(string dialogName, IDialogWindow window, IDialogParameters parameters)
        {
            if (!(_containerExtension.Resolve<object>(dialogName) is FrameworkElement frameworkElement))
            {
                throw new NullReferenceException("A dialog's content must be a FrameworkElement");
            }

            if (!(frameworkElement.DataContext is IDialogAware dialogAware))
            {
                throw new NullReferenceException("A dialog's ViewModel must implement the IDialogAware interface");
            }

            ConfigureDialogWindowProperties(window, frameworkElement, dialogAware);
            MvvmHelpers.ViewAndViewModelAction(dialogAware, delegate (IDialogAware d)
            {
                d.OnDialogOpened(parameters);
            });
        }

        private void ConfigureDialogWindowEvents(IDialogWindow dialogWindow, Action<IDialogResult> callback)
        {
            Action<IDialogResult> requestCloseHandler = null;
            requestCloseHandler = delegate (IDialogResult o)
            {
                dialogWindow.Result = o;
                dialogWindow.Close();
            };
            RoutedEventHandler loadedHandler = null;
            loadedHandler = delegate
            {
                dialogWindow.Loaded -= loadedHandler;
                dialogWindow.GetDialogViewModel().RequestClose += requestCloseHandler;
            };
            dialogWindow.Loaded += loadedHandler;
            CancelEventHandler closingHandler = null;
            closingHandler = delegate (object o, CancelEventArgs e)
            {
                if (!dialogWindow.GetDialogViewModel().CanCloseDialog())
                {
                    e.Cancel = true;
                }
            };
            dialogWindow.Closing += closingHandler;
            EventHandler closedHandler = null;
            closedHandler = delegate
            {
                dialogWindow.Closed -= closedHandler;
                dialogWindow.Closing -= closingHandler;
                dialogWindow.GetDialogViewModel().RequestClose -= requestCloseHandler;
                dialogWindow.GetDialogViewModel().OnDialogClosed();
                if (dialogWindow.Result == null)
                {
                    dialogWindow.Result = new DialogResult();
                }

                callback?.Invoke(dialogWindow.Result);
                dialogWindow.DataContext = null;
                dialogWindow.Content = null;
            };
            dialogWindow.Closed += closedHandler;
        }

        private void ConfigureDialogWindowProperties(IDialogWindow window, FrameworkElement dialogContent, IDialogAware viewModel)
        {
            Style windowStyle = Dialog.GetWindowStyle(dialogContent);
            if (windowStyle != null)
            {
                window.Style = windowStyle;
            }

            window.Content = dialogContent;
            window.DataContext = viewModel;
            if (window.Owner == null)
            {
                window.Owner = SharedModule.MainWindow;
            }
        }
    }
}
