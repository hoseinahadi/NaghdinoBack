using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.DTO.Feature;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureBusiness _business;

        public FeatureController(IFeatureBusiness Business)
        {
            _business = Business;
        }
        [HttpPost("AddNewFeature")]
        public IActionResult AddNew(FeatureAddEditModel model)
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
        [HttpPost("UpdateFeature")]
        public IActionResult Update(FeatureAddEditModel model)
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

        [HttpPost("SearchFeature")]
        public IActionResult Search(FeatureSearchModel model ,int recordCount)
        {
            
            var result = _business.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteFeature")]
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

                return BadRequest("This Feature Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetFeature")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllFeature")]
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
