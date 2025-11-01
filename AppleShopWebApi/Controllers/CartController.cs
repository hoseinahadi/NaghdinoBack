using BusinessServiceContract.Services;
using DomainModel.DTO.Cart;
using DomainModel.DTO.User;
using DomainModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    
    public class CartController : Controller
    {
        private readonly ICartBusiness _cartBusiness;
        private readonly IUserBusiness _userBusiness;

        public CartController(ICartBusiness cartBusiness, IUserBusiness userBusiness)
        {
            _cartBusiness = cartBusiness;
            _userBusiness = userBusiness;
        }

        [HttpPost("AddNewCart")]
        public IActionResult AddNew(CartAddOrEditModel model)
        {
            
                if (ModelState.IsValid)
                {
                    if (model.UserId != 0)
                    {
                        var user = _userBusiness.Get(model.UserId);
                        if (user.MainResults == null)
                        { 
                            return NotFound("This user Not Found");
                        }
                        var result = _cartBusiness.Add(model);
                        if (result.Success == true)
                        {
                            return Ok(result);
                        }

                        return BadRequest(result);
                    }

                
                } 
                return BadRequest("Model not valid");

        }

        [HttpPost("UpdateCart")]
        public IActionResult Update(CartAddOrEditModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.UserId != 0)
                {
                    var user = _userBusiness.Get(model.UserId);
                    if (user.MainResults == null)
                    {
                        return NotFound("This user Not Found");
                    }
                    var result = _cartBusiness.Update(model);
                    if (result.Success == true)
                    {
                        return Ok(result);
                    }

                    return BadRequest(result);
                }

            }

            return BadRequest("Model Not Valid");
        }

        [HttpPost("DeleteCart")]
        public IActionResult Delete(int id)
        {
            var cart = _cartBusiness.Get(id);
            if (cart!=null)
            {
                var result = _cartBusiness.Delete(id);
                if (result.Success==true)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            return NotFound("this Cart not found");
        }
    }
}
