using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Revit
{
    public class AppFrameworkCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AppFrameworkCoreSharedModule).GetAssembly());
        }
    }
}