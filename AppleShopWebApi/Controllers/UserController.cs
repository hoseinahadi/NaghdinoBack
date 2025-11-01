using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.DTO.OrderReturn;
using DomainModel.DTO.User;
using Framework.Password;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserBusiness _business;
        private readonly IPasswordHasher _passwordHasher;

        public UserController(IUserBusiness business, IPasswordHasher passwordHasher)
        {
            _business = business;
            _passwordHasher = passwordHasher;
        }
        [HttpPost("AddNewUser")]
        public IActionResult AddNew(UserAddEditModel model)
        {
            
            if (ModelState.IsValid)
            {
                var pass = _passwordHasher.Hash(model.Password);
                model.Password = pass;
                var result = _business.Add(model);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("UpdateUser")]
        public IActionResult Update(UserAddEditModel model)
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

        [HttpPost("SearchUser")]
        public IActionResult Search(UserSearchModel model ,int recordCount)
        {
            
            var result = _business.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteUser")]
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

                return BadRequest("This User Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetUser")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllUser")]
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
