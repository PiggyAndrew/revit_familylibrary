using Revit.Shared.Entity.Family;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Revit.Application.Converter
{

    public class ConvertFamilyAuditEnumToString : IValueConverter
    {
        private const string _auditing = "审核中";
        private const string _pass = "已审核通过";
        private const string _notPass = "未通过";
        private const string _retry = "返回修改";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is FamilyAuditStatus status)
            {
                switch (status)
                {
                    case FamilyAuditStatus.Auditing: return _auditing;
                    case FamilyAuditStatus.Pass: return _pass;
                    case FamilyAuditStatus.NotPass: return _notPass;
                    case FamilyAuditStatus.Retry: return _retry;
                    default:
                        break;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string status)
            {
                switch (status)
                {
                    case _auditing : return FamilyAuditStatus.Auditing;
                    case _pass: return FamilyAuditStatus.Pass;
                    case _notPass: return FamilyAuditStatus.NotPass;
                    case _retry: return FamilyAuditStatus.Retry;
                    default:
                        break;
                }
            }
            return value;
        }
    }
}
