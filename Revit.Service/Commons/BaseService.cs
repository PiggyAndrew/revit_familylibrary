using AutoMapper;
using Revit.EntityFrameworkCore;

namespace Revit.Service.Commons
{
    public class BaseService
    {
        protected readonly IMapper _mapper;

        public BaseService( IMapper mapper)
        {
            _mapper = mapper;
        }



    }
}
