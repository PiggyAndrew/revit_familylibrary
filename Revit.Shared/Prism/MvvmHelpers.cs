using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Prism.Mvvm;

namespace Revit.Shared.Prism
{
    /// <summary>
    /// Helper class for MVVM.
    /// </summary>
    public static class MvvmHelpers
    {
        public static void ViewAndViewModelAction<T>(object view, Action<T> action) where T : class
        {
            if (view is T obj)
            {
                action(obj);
            }

            if (view is FrameworkElement frameworkElement && frameworkElement.DataContext is T obj2)
            {
                action(obj2);
            }
        }

        public static T GetImplementerFromViewOrViewModel<T>(object view) where T : class
        {
            if (view is T result)
            {
                return result;
            }

            if (view is FrameworkElement frameworkElement)
            {
                return frameworkElement.DataContext as T;
            }

            return null;
        }
    }
}
