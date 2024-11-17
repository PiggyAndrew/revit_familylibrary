using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Revit.Commons;
using Revit.Shared.Entity.Family;

namespace Revit.Application.Models.Category
{
    public partial class CategoryListModel : TreeNode
    {
        [ObservableProperty]
        public long _id;

        [ObservableProperty]
        public long? _parentId;

        [ObservableProperty]
        public string _name;

        [ObservableProperty] public CategoryType _categoryType=CategoryType.ElementType;
    }
}
