using BusinessServiceContract.Services;
using DomainModel.DTO.Role;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleBusiness _business;

        public RoleController(IRoleBusiness Business)
        {
            _business = Business;
        }
        [HttpPost("AddNewRole")]
        public IActionResult AddNew(RoleAddEditModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _business.AddNew(model);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("UpdateRole")]
        public IActionResult Update(RoleAddEditModel model)
        {
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


        [HttpDelete("DeleteRole")]
        public IActionResult Delete(int id)
        {
            
            if (id!=0)
            {
                var category = _business.Get(id);
                if (category != null)
                {
                    var result = _business.Delete(id);
                    if (result.Success == true)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }

                return BadRequest("This Role Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetRole")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllRole")]
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
