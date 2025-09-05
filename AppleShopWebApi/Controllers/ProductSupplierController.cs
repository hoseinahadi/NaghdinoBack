using BusinessServiceContract.Services;
using DataAccessServicessContract.Services;
using DomainModel.DTO.Category;
using DomainModel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class ProductSupplierController : Controller
    {
        private readonly IProductSupplierBusiness _business;

        public ProductSupplierController(IProductSupplierBusiness business)
        {
            _business = business;
        }

        [HttpPost("AddNewProductSupplier")]
        [Authorize]
        public IActionResult AddNew(ProductSupplier model)
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



        [HttpPost("SearchProductSupplier")]
        public IActionResult Search(ProductSupplier model, int recordCount)
        {

            var result = _business.Search(model, out recordCount);
            if (result.MainResults != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("UpdateProductSupplier")]
        [Authorize]

        public IActionResult Update(ProductSupplier model)
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

        

        [HttpDelete("DeleteProductSupplier")]
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

        [HttpGet("GetProductSupplier")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllProductSupplier")]
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
