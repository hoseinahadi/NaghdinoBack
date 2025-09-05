using BusinessServiceContract.Services;
using DomainModel.DTO.Employee;
using DomainModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        private readonly IAccessBusiness _accessBusiness;
        private readonly IEmployeeBusiness _employeeBusiness;

        public AccessController(IAccessBusiness accessBusiness)
        {
            _accessBusiness = accessBusiness;
        }
        [HttpGet("EmployeeAccess")]
        public IActionResult GetUserLevel(EmployeeSearchModel em)
        {

            var x = 10;
            var hosein = "hosein";
            var access = _employeeBusiness.Search(em,out x);
            return Ok(access);
        }
    }
}
