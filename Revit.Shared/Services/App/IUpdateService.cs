 using System.Threading.Tasks;

namespace Revit.Shared.Services.App
{
    public interface IUpdateService
    {
        Task CheckVersion();
    }
}
