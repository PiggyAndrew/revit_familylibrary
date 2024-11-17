using Revit.ApiClient;
using Revit.MultiTenancy.HostDashboard;
using Revit.MultiTenancy.HostDashboard.Dto;
using System.Threading.Tasks;

namespace Revit.Application.MultiTenancy.HostDashboard
{
    public class HostDashboardAppService : ProxyAppServiceBase, IHostDashboardAppService
    {
        public HostDashboardAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<GetEditionTenantStatisticsOutput> GetEditionTenantStatistics(GetEditionTenantStatisticsInput input)
        {
            return await ApiClient.GetAsync<GetEditionTenantStatisticsOutput>(GetEndpoint(nameof(GetEditionTenantStatistics)), input);
        }

        public async Task<GetIncomeStatisticsDataOutput> GetIncomeStatistics(GetIncomeStatisticsDataInput input)
        {
            return await ApiClient.GetAsync<GetIncomeStatisticsDataOutput>(GetEndpoint(nameof(GetIncomeStatistics)), input);
        }

        public async Task<GetRecentTenantsOutput> GetRecentTenantsData()
        {
            return await ApiClient.GetAsync<GetRecentTenantsOutput>(GetEndpoint(nameof(GetRecentTenantsData)));
        }

        public async Task<GetExpiringTenantsOutput> GetSubscriptionExpiringTenantsData()
        {
            return await ApiClient.GetAsync<GetExpiringTenantsOutput>(GetEndpoint(nameof(GetSubscriptionExpiringTenantsData)));
        }

        public async Task<TopStatsData> GetTopStatsData(GetTopStatsInput input)
        {
            return await ApiClient.GetAsync<TopStatsData>(GetEndpoint(nameof(GetTopStatsData)), input);
        }
    }
}