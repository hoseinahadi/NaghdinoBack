using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.DTO.Employee;
using DomainModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusiness _business;

        public EmployeeController(IEmployeeBusiness Business)
        {
            _business = Business;
        }
        [HttpPost("AddNewEmployee")]
        public IActionResult AddNew(EmployeeAddOrEditModel model)
        {
            if (model.ParentId!=0)
            {
                var result = _business.Get(model.ParentId??0);
                if (result==null)
                {
                    return NotFound("This Parent Not Found");
                }
            }
            if (model.RoleId != 0)
            {
                var result = _business.Get(model.RoleId);
                if (result == null)
                {
                    return NotFound("This Role Not Found");
                }
            }

            if (ModelState.IsValid)
            {
                var result = _business.Add(model);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("UpdateEmployee")]
        public IActionResult Update(EmployeeAddOrEditModel model)
        {
            if (model.ParentId != 0)
            {
                var result = _business.Get(model.ParentId ?? 0);
                if (result == null)
                {
                    return NotFound("This Parent Not Found");
                }
            }
            if (model.RoleId != 0)
            {
                var result = _business.Get(model.RoleId);
                if (result == null)
                {
                    return NotFound("This Role Not Found");
                }
            }
            if (ModelState.IsValid)
            {
                var result = _business.Update(model);
                if (result.Success == true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }

        [HttpPost("SearchEmployee")]
        public IActionResult Search(EmployeeSearchModel model ,int recordCount)
        {
            
            var result = _business.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteEmployee")]
        public IActionResult Delete(int id)
        {
            
            if (id!=0)
            {
                var employee = _business.Get(id);
                if (employee != null)
                {
                    var result = _business.Delete(id);
                    if (result.Success == true)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }

                return BadRequest("This Employee Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetEmployee")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllEmployee")]
        public IActionResult GetAll()
        {
            var result = _business.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

    }
}
