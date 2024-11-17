using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Extension
{
    public static class UnitExtension
    {

        public static double ConvertToFeet(this double val)
        {
#if RVT_17 || RVT_18||RVT_19 ||RVT_20 || DEBUG
            return UnitUtils.Convert(val, DisplayUnitType.DUT_CUBIC_MILLIMETERS, DisplayUnitType.DUT_DECIMAL_FEET);
#endif
#if RVT_22
            return UnitUtils.Convert(val, DisplayUnitType.MILLIMETERS, DisplayUnitType.FEET);
#else
#pragma warning disable CS0162 // 检测到无法访问的代码
            return 2;
#pragma warning restore CS0162 // 检测到无法访问的代码
#endif

        }
    }
}
