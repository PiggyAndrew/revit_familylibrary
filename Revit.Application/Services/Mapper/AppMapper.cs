using AutoMapper;
using Revit.Shared.Models;
using Revit.Shared.Services.App;
using Revit.Application.Models;

namespace Revit.Application.Services
{
    public class AppMapper : IAppMapper
    {
        public AppMapper()
        {
            var configuration = new MapperConfiguration(configure =>
            {
                configure.AddProfile<SharedModuleMapper>();
                configure.AddProfile<AdminModuleMapper>();
            });
            Current = configuration.CreateMapper();
        }

        public IMapper Current { get; }

        public TDestination Map<TDestination>(object source) => Current.Map<TDestination>(source);
    }
}
