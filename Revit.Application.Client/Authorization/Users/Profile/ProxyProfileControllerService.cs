using Revit.ApiClient;
using Revit.Authorization.Users.Profile.Dto;
using Flurl.Http.Content;
using System;
using System.Threading.Tasks;

namespace Revit.Authorization.Users.Profile
{
    public class ProxyProfileControllerService : ProxyControllerBase
    {
        public ProxyProfileControllerService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<UploadProfilePictureOutput> UploadProfilePicture(Action<CapturedMultipartContent> buildContent)
        {
            return await ApiClient.PostMultipartAsync<UploadProfilePictureOutput>(GetEndpoint(nameof(UploadProfilePicture)), buildContent);
        }

        public async Task<UploadFileOutput> UploadVersionFile(Action<CapturedMultipartContent> buildContent)
        { 
            return await ApiClient.PostMultipartAsync<UploadFileOutput>(GetEndpoint(nameof(UploadVersionFile)), buildContent);
        }
    }
}