using CRUD_API.Models;
using CRUD_API.ViewModels;

namespace CRUD_API.Interfaces
{
    public interface IResidentStorage
    {
        List<ResidentGetAllViewModel> GetAll(AgeFilter ageFilter, SexFilter sexFilter, OwnerParameters ownerParameters);
        ResidentByIdViewModel GetById(string id);
    }
}
