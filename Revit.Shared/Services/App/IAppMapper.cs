using AutoMapper;

namespace Revit.Shared.Services.App
{
    public interface IAppMapper
    {
        IMapper Current { get; }

        TDestination Map<TDestination>(object source);
    }
}
