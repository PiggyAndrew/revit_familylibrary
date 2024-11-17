using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revit.Extension
{
    public static class ColorExtension
    {
        public static Autodesk.Revit.DB.Color ConvertToRevitColor(this System.Drawing.Color color)
        {
            Autodesk.Revit.DB.Color revitColor = new Autodesk.Revit.DB.Color(color.R, color.G, color.B);
            return revitColor;
        }


    }
}
