using System.Reflection;

namespace Revit.WebAPI.Extension
{
    /// <summary>
    /// Assembly扩展
    /// </summary>
    public static class AssembleyExtension
    {


        /// <summary>
        /// 获取所有程序集
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        public static List<Assembly> GetReferanceAssemblies(this AppDomain domain)
        {
            var list = new List<Assembly>();
            domain.GetAssemblies().ToList().ForEach(i =>
            {
                GetReferanceAssemblies(i, list);
            });
            return list;
        }

        static void GetReferanceAssemblies(Assembly assembly, List<Assembly> list)
        {
            assembly.GetReferencedAssemblies().ToList().ForEach(i =>
            {
                    var assembly = Assembly.Load(i);
                    if (!list.Contains(assembly))
                    {
                        list.Add(assembly);
                        GetReferanceAssemblies(assembly, list);
                    }
            });
        }
    }
}
