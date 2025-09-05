using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountBusiness _business;

        public DiscountController(IDiscountBusiness Business)
        {
            _business = Business;
        }
        [HttpPost("AddNewDiscount")]
        public IActionResult AddNew(DiscountAddOrEditModel model)
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
        [HttpPost("UpdateDiscount")]
        public IActionResult Update(DiscountAddOrEditModel model)
        {
            var xx = new CategoryDiscount
            {
                CategoryId = 1,
                DiscountId = 1
            };
            var rs = Json(xx);
            
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

        [HttpPost("SearchDiscount")]
        public IActionResult Search(DiscountSearchModel model ,int recordCount)
        {
            
            var result = _business.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteDiscount")]
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

                return BadRequest("This Discount Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetDiscount")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllDiscount")]
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
