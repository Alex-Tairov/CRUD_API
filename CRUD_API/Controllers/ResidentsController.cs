using Microsoft.AspNetCore.Mvc;
using CRUD_API.Interfaces;
using CRUD_API.Models;

namespace CRUD_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ResidentsController : ControllerBase
    {
        private readonly IResidentStorage _residentStorage;
       
        public ResidentsController(IResidentStorage residentStorage)
        {
            _residentStorage = residentStorage;
        }

        [HttpPost]
        public IActionResult GetAll(ComplexFilter complexFilter)
        {
            var filteredResidents = _residentStorage.GetAll(complexFilter.AgeFilter, complexFilter.SexFilter, complexFilter.OwnerParameters);
            if(filteredResidents==null)
                return BadRequest("Неверные параметры сортировки");
            return Ok(filteredResidents);
        }

        [HttpGet]
        public IActionResult GetById(string id)
        {
            var resident=_residentStorage.GetById(id);
            if (resident == null)
                return BadRequest("Пользователя с данным Id несуществует");
            return Ok(resident);
         }

    }
}
