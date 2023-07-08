using AutoMapper;
using CRUD_API.Database;
using CRUD_API.Interfaces;
using CRUD_API.Models;
using CRUD_API.ViewModels;

namespace CRUD_API.Storages
{
    public class ResidentStorage : IResidentStorage
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public ResidentStorage(AppDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public List<ResidentGetAllViewModel> GetAll(AgeFilter ageFilter, SexFilter sexFilter, OwnerParameters ownerParameters)
        {
            var residents = _dbContext.Residents.ToList()
                                              .OrderBy(on => on.Name)
                                              .Skip((ownerParameters.PageNumber - 1) * ownerParameters.PageSize)
                                              .Take(ownerParameters.PageSize)
                                              .ToList();

            if (!(ageFilter.StartAge == 0 && ageFilter.EndAge == 0))
            {
                residents = residents.Where(x => x.Age >= ageFilter.StartAge && x.Age <= ageFilter.EndAge).ToList();
            }
               
            if (!(sexFilter.Sex == "string"))
            {
                residents = residents.Where(res => res.Sex == sexFilter.Sex).ToList();
            }

            return residents.Select(_mapper.Map<ResidentGetAllViewModel>).ToList();
        }


        public ResidentByIdViewModel GetById(string id)
        {
            var resident = _dbContext.Residents.ToList().FirstOrDefault(x=>x.Id==id);
            
            return _mapper.Map<ResidentByIdViewModel>(resident);
        }


    }
}
