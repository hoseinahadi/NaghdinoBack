using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsBusiness _contactUsBusiness;

        public ContactUsController(IContactUsBusiness contactUsBusiness)
        {
            _contactUsBusiness = contactUsBusiness;
        }
        [HttpPost("AddNewContactUs")]
        public IActionResult AddNew(ContactUsAddEditModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _contactUsBusiness.Add(model);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("UpdateContactUs")]
        public IActionResult Update(ContactUsAddEditModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _contactUsBusiness.Update(model);
                if (result.Success == true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }

        [HttpPost("SearchContactUs")]
        public IActionResult Search(ContactUsSearchModel model ,int recordCount)
        {
            
            var result = _contactUsBusiness.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteContactUs")]
        public IActionResult Delete(int id)
        {
            
            if (id!=0)
            {
                var category = _contactUsBusiness.Get(id);
                if (category != null)
                {
                    var result = _contactUsBusiness.Delete(id);
                    if (result.Success == true)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }

                return BadRequest("This ContactUs Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetContactUs")]
        public IActionResult Get(int id)
        {
            var result = _contactUsBusiness.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllContactUs")]
        public IActionResult GetAll()
        {
            var result = _contactUsBusiness.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

    }
}
