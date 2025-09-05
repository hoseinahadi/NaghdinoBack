using BusinessServiceContract.Services;
using DataAccessServicessContract.Services;
using DomainModel.DTO.Category;
using DomainModel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class ProductCartController : Controller
    {
        private readonly IProductCartBusiness _business;

        public ProductCartController(IProductCartBusiness business)
        {
            _business = business;
        }

        [HttpPost("AddNewProductCart")]
        [Authorize]
        public IActionResult AddNew(ProductCart model)
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
        [HttpPost("UpdateProductCart")]
        [Authorize]

        public IActionResult Update(ProductCart model)
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
        [HttpPost("SearchProductCart")]
        public IActionResult Search(ProductCart model, int recordCount)
        {

            var result = _business.Search(model, out recordCount);
            if (result.MainResults != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpDelete("DeleteProductCart")]
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

                return BadRequest("This CategoryFeature Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetProductCart")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllProductCart")]
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
