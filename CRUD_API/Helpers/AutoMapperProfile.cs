using AutoMapper;
using CRUD_API.Models;
using CRUD_API.ViewModels;

namespace CRUD_API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Resident, ResidentByIdViewModel>().ReverseMap();
            CreateMap<Resident, ResidentGetAllViewModel>().ReverseMap();
        }
    }
}
