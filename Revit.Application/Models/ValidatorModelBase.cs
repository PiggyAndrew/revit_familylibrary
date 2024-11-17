using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Application.Models
{
    public partial class ValidatorModelBase:ObservableValidator
    {
        public ValidatorModelBase() { }

        [ObservableProperty]
        public bool _isCheck;
    }
}
