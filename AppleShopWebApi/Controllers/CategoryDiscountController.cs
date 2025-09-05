using Business.IMP;
using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class CategoryDiscountController : Controller
    {
        private readonly ICategoryDiscountBusiness _categoryDiscountBusiness;

        public CategoryDiscountController(ICategoryDiscountBusiness categoryDiscountBusiness)
        {
            _categoryDiscountBusiness = categoryDiscountBusiness;
        }

        [HttpPost("AddNewCategoryDiscount")]
        [Authorize]
        public IActionResult AddNew(CategoryDiscount model)
        {
            if (ModelState.IsValid)
            {

                var result = _categoryDiscountBusiness.Add(model);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("UpdateCategoryDiscount")]
        [Authorize]

        public IActionResult Update(CategoryDiscount model)
        {
            if (ModelState.IsValid)
            {

                var result = _categoryDiscountBusiness.Update(model);
                if (result.Success == true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("SearchCategoryDiscount")]
        public IActionResult Search(CategoryDiscount model, int recordCount)
        {

            var result = _categoryDiscountBusiness.Search(model, out recordCount);
            if (result.MainResults != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpDelete("DeleteCategoryDiscount")]
        public IActionResult Delete(int id)
        {
            
            if (id!=0)
            {
                var category = _categoryDiscountBusiness.Get(id);
                if (category != null)
                {
                    var result = _categoryDiscountBusiness.Delete(id);
                    if (result.Success == true)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }

                return BadRequest("This CategoryDiscount Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetCategoryDiscount")]
        public IActionResult Get(int id)
        {
            var result = _categoryDiscountBusiness.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllCategoryDiscount")]
        public IActionResult GetAll()
        {
            var result = _categoryDiscountBusiness.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

    }
}
