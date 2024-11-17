using AutoMapper;
using Revit.Entity.Problem;
using Revit.Repository;
using Revit.Service.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.Problems
{
    internal class ProblemService : BaseService
    {
        private readonly IBaseRepository<R_Problem> problemRepository;

        public ProblemService(IMapper mapper,IBaseRepository<R_Problem> problemRepository) : base(mapper)
        {
            this.problemRepository = problemRepository;
        }



    }
}
