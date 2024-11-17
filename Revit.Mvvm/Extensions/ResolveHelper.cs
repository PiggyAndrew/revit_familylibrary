using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Revit.Mvvm.Extensions
{
    public static class ResolveHelper
    {
        private static string _moduleDirectory;

        private static object _domainResolvers;

        //
        // 摘要:
        //     Subscribes the current domain to resolve dependencies for the type.
        //
        // 类型参数:
        //   T:
        //     Type, to search for dependencies in the directory where this type is defined
        //
        //
        // 言论：
        //     Dependencies are searched in a directory of the specified type. At the time of
        //     dependency resolution, all other dependency resolution methods for the domain
        //     are disabled, this requires calling Nice3point.Revit.Toolkit.Helpers.ResolveHelper.EndAssemblyResolve
        //     immediately after executing user code where dependency failures occur.
        public static void BeginAssemblyResolve<T>()
        {
            BeginAssemblyResolve(typeof(T));
        }

        //
        // 摘要:
        //     Subscribes the current domain to resolve dependencies for the type.
        //
        // 参数:
        //   type:
        //     Type, to search for dependencies in the directory where this type is defined
        //
        //
        // 言论：
        //     Dependencies are searched in a directory of the specified type. At the time of
        //     dependency resolution, all other dependency resolution methods for the domain
        //     are disabled, this requires calling Nice3point.Revit.Toolkit.Helpers.ResolveHelper.EndAssemblyResolve
        //     immediately after executing user code where dependency failures occur.
        public static void BeginAssemblyResolve(Type type)
        {
            if (_domainResolvers == null && !(type.Module.FullyQualifiedName == "<Unknown>"))
            {
                FieldInfo field = AppDomain.CurrentDomain.GetType().GetField("_AssemblyResolve", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic);
                object value = field.GetValue(AppDomain.CurrentDomain);
                field.SetValue(AppDomain.CurrentDomain, null);
                _domainResolvers = value;
                _moduleDirectory = Path.GetDirectoryName(type.Module.FullyQualifiedName);
                AppDomain.CurrentDomain.AssemblyResolve += OnAssemblyResolve;
            }
        }

        //
        // 摘要:
        //     Unsubscribes the current domain to resolve dependencies for the type.
        public static void EndAssemblyResolve()
        {
            if (_domainResolvers != null)
            {
                AppDomain.CurrentDomain.GetType().GetField("_AssemblyResolve", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic).SetValue(AppDomain.CurrentDomain, _domainResolvers);
                _domainResolvers = null;
                _moduleDirectory = null;
            }
        }

        private static Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            string name = new AssemblyName(args.Name).Name;
            string text = Path.Combine(_moduleDirectory, name + ".dll");
            if (!File.Exists(text))
            {
                return null;
            }

            return Assembly.LoadFrom(text);
        }
    }
}
