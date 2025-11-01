using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.DTO.OrderReturn;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class OrderReturnController : Controller
    {
        private readonly IOrderReturnBusiness _business;

        public OrderReturnController(IOrderReturnBusiness Business)
        {
            _business = Business;
        }
        [HttpPost("AddNewOrderReturn")]
        public IActionResult AddNew(OrderReturnAddEditModel model)
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
        [HttpPost("UpdateOrderReturn")]
        public IActionResult Update(OrderReturnAddEditModel model)
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

        [HttpPost("SearchOrderReturn")]
        public IActionResult Search(OrderReturnSearchModel model ,int recordCount)
        {
            
            var result = _business.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteOrderReturn")]
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

                return BadRequest("This OrderReturn Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetOrderReturn")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllOrderReturn")]
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
