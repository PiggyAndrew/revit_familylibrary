using System.Collections.Generic;
using System.Collections.ObjectModel;
using Revit.Shared.Models;

namespace Revit.Application.Services
{
    public interface INavigationMenuService
    {
        ObservableCollection<NavigationItem> GetAuthMenus(Dictionary<string, string> permissions); 
    }
}