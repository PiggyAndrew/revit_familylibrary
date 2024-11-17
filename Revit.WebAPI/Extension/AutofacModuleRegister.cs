using Autofac;
using Revit.Repository;
using System.Reflection;
using Module = Autofac.Module;

namespace Revit.WebAPI.Extension
{
    public class AutofacModuleRegister:Module
    {

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency(); //注册仓储
        }
    }
}
