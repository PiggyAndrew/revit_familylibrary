using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Revit.Mvvm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity
{
    public class DataContext : IDataContext
    {

        public DataContext(ExternalCommandData externalCommandData)
        {
            ExternalCommandData = externalCommandData;
        }

        public Document Document { get => ExternalCommandData.Application.ActiveUIDocument.Document; }
        public ExternalCommandData ExternalCommandData { get; set; }



        public Document GetDocument()
        {
            return Document;
        }

        public UIApplication GetUIApplication()
        {
            return ExternalCommandData.Application;
        }

        public UIDocument GetUIDocument()
        {
            return new UIDocument(GetDocument());
        }

        public Autodesk.Revit.ApplicationServices.Application GetApplication()
        {
            return GetUIApplication().Application;
        }
    }
}
