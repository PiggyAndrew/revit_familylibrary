using Microsoft.AspNetCore.Http.Features;

namespace Revit.WebAPI.Extension
{
    public static  class FileUploadConfigExtension
    {
        public static void  ConfigFile(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit=long.MaxValue;
                options.MemoryBufferThreshold=int.MaxValue;
                options.ValueLengthLimit = int.MaxValue;
            });
        }
    }
}
