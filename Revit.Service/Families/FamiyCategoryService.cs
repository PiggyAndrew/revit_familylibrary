using AutoMapper;
using Revit.Entity.Family;
using Revit.Repository;
using Revit.Service.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.Families
{
    public class FamiyCategoryService : BaseService, IFamiyCategoryService
    {
        private readonly IBaseRepository<R_FamilyCategory> familyCategoryRepository;

        public FamiyCategoryService(IMapper mapper, IBaseRepository<R_FamilyCategory> familyCategoryRepository) : base(mapper)
        {
            this.familyCategoryRepository = familyCategoryRepository;
        }

        public async Task<int> SaveFamilyCategies(long familyId, IEnumerable<long> categiresIds)
        {
            var results = categiresIds.Select<long, R_FamilyCategory>(x => new R_FamilyCategory() { FamilyId = familyId, CategoryId = x }).ToList();
            var count = familyCategoryRepository.AddRange(results);
            return count;
        }


        public async Task<IEnumerable<R_FamilyCategory>> GetFamilyCategies(long familyId)
        {
            var results = familyCategoryRepository.GetList(x=>x.FamilyId.Equals(familyId));
            return results;
        }
    }
}
