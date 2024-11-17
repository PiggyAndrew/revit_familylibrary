using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Revit.Commons
{
    public partial class TreeNode: ViewEntityBase
    {

        [ObservableProperty]
        private ObservableCollection<object> _children = new ObservableCollection<object>();

        [ObservableProperty]
        private string _name;

        public TreeNode()
        {
            PropertyChanged += TreeNode_PropertyChanged;
        }

        private void TreeNode_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName==nameof(IsChecked))
            {
                foreach (ViewEntityBase child in _children)
                {
                    child.IsChecked = this.IsChecked;
                }
            }
        }
    }
}