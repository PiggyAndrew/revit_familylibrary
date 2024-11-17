using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Revit.Mvvm.Interface;
using System;

namespace Revit.Mvvm
{
    public class UIProvider : IUIProvider
    {

        private UIControlledApplication _application;

        public UIProvider(UIControlledApplication application)
        {
            _application = application;
        }

        public AddInId GetAddInId()
        {
            return GetUIControlledApplication().ActiveAddInId;
        }

        public ControlledApplication GetApplication()
        {
            return GetUIControlledApplication().ControlledApplication;
        }

        public UIControlledApplication GetUIControlledApplication()
        {
            return _application;
        }

        public IntPtr GetWindowHandle()
        {
            //return GetUIControlledApplication().MainWindowHandle;
            return new IntPtr();
        }
    }
}
