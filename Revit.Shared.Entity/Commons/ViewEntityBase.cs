using CommunityToolkit.Mvvm.ComponentModel;
using Revit.Shared.Entity.Commons;

namespace Revit.Commons
{
    public partial class ViewEntityBase : ViewDtoBase
    {
        [ObservableProperty]
        private bool _isSelected;
        [ObservableProperty]
        private bool _isChecked;

        public ViewEntityBase()
        {
        }

    }
}
