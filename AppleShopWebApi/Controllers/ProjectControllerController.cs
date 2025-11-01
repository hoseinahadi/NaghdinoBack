using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.DTO.OrderReturn;
using DomainModel.DTO.ProjectController;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class ProjectControllerController : Controller
    {
        private readonly IProjectControllerBusiness _business;

        public ProjectControllerController(IProjectControllerBusiness Business)
        {
            _business = Business;
        }
        [HttpPost("AddNewProjectController")]
        public IActionResult AddNew(ProjectControllerAddEditModel model)
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
        [HttpPost("UpdateProjectController")]
        public IActionResult Update(ProjectControllerAddEditModel model)
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


        [HttpDelete("DeleteProjectController")]
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

                return BadRequest("This ProjectController Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetProjectController")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllProjectController")]
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
