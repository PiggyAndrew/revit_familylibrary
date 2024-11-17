using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Mvvm.Interface
{
    public interface IUIProvider//插件的上下文
    {
        UIControlledApplication GetUIControlledApplication(); //代表Autodesk Revit用户界面，提供对UI自定义方法和事件的访问。
        ControlledApplication GetApplication();//表示无法访问文档的Autodesk Revit应用程序。
                                               //它为外部应用程序OnStartup/OnShutdown提供选项和其他应用程序范围的数据和设置
        IntPtr GetWindowHandle(); //句柄：智能指针

        AddInId GetAddInId(); //标识注册到Revit的插件




    }
}
