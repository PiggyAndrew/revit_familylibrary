using Abp.Application.Services;
using Abp.Extensions;
using Revit.ApiClient;

namespace Revit
{
    public abstract class ProxyAppServiceBase : IApplicationService
    {
        public AbpApiClient ApiClient { get; set; }

        public const string ApiBaseUrl = "api/";

        private readonly string _serviceUrlSegment;

        protected ProxyAppServiceBase(AbpApiClient apiClient)
        {
            ApiClient = apiClient;
            _serviceUrlSegment = GetServiceUrlSegmentByConvention();
        }

        protected string GetEndpoint(string methodName="")
        {
            var endpoint = "";
            if (!string.IsNullOrEmpty(methodName))
            {
                endpoint = "/" + methodName;
            }
            return ApiBaseUrl + _serviceUrlSegment + endpoint;
        }

        private string GetServiceUrlSegmentByConvention()
        {
            return GetType()
                .Name
                .RemovePreFix("Proxy")
                .RemovePostFix("AppServiceProxy", "AppService");
        }
    }
}