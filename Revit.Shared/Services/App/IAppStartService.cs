using System.Windows;

namespace Revit.Shared.Services.App
{
    public interface IAppStartService
    {
        void CreateShell();

        void Logout();

        void Exit();
    }
}
