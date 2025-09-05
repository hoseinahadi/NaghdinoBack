using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.DTO.Gender;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class GenderController : Controller
    {
        private readonly IGenderBusiness _business;

        public GenderController(IGenderBusiness Business)
        {
            _business = Business;
        }
        [HttpPost("AddNewGender")]
        public IActionResult AddNew(GenderAddEditModel model)
        {
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
        [HttpPost("UpdateGender")]
        public IActionResult Update(GenderAddEditModel model)
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
        [HttpDelete("DeleteGender")]
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
                return BadRequest("This Gender Not Found");
            }
            return BadRequest("Select Id ");
        }

        [HttpGet("GetGender")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllGender")]
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
