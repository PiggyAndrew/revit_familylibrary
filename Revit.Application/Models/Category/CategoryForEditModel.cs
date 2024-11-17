using Revit.Shared.Entity.Family;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Commons;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Revit.Families
{
    public partial class CategoryForEditModel : ViewEntityBase
    {
        [ObservableProperty]
        public long? _parentId;

        [ObservableProperty]
        public string _name;

        [ObservableProperty] public CategoryType _categoryType=CategoryType.ElementType;

        [ObservableProperty]
        public ObservableCollection<object> _childs = new ObservableCollection<object>();
    }
}
