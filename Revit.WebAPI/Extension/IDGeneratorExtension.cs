using AutoMapper;
using Snowflake.Core;
using System.Reflection;

namespace Revit.WebAPI.Extension
{
    /// <summary>
    /// 雪花ID生成扩展
    /// </summary>
    public static class IDGeneratorExtension
    {

        internal static void AddIdWorker(this WebApplicationBuilder builder)
        {
           var worker=new IdWorker(1, 1);
            builder.Services.AddSingleton(worker);
        }


    }
}
