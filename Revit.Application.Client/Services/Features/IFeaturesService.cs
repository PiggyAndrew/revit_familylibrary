using Abp.Application.Services.Dto;
using Revit.Editions.Dto; 
using System.Collections.Generic; 

namespace Revit.Admin.Services
{
    public interface IFeaturesService
    {
        void CreateFeatures(List<FlatFeatureDto> features, List<NameValueDto> featureValues);

        List<NameValueDto> GetSelectedItems();
    }
}
