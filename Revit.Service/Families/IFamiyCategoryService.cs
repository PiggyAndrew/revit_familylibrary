
namespace Revit.Service.Families
{
    public interface IFamiyCategoryService
    {
        Task<int> SaveFamilyCategies(long familyId, IEnumerable<long> categiresIds);
    }
}