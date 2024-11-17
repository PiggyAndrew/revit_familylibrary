using CommunityToolkit.Mvvm.ComponentModel; 

namespace Revit.Shared.Models
{
    [INotifyPropertyChanged]
    public partial class EntityObject 
    {
        public int Id { get; set; }

        public EntityObject()
        { }

        public EntityObject(int id) => Id = id;
    }
}