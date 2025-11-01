using BusinessServiceContract.Services;
using DomainModel.DTO.Address;
using DomainModel.DTO.Carrier;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressBusiness _business;

        public AddressController(IAddressBusiness business)
        {
            _business = business;
        }
        [HttpPost("AddNewAddress")]
        public IActionResult AddNew(AddressAddOrEditModel model)
        {
            var result = _business.Add(model);
            if (result.Success==true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
        [HttpGet("UpdateAddressInfo")]
        public IActionResult Update(int id)
        {
            var model = _business.Get(id);
            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(model);
        }

        [HttpPost("UpdateAddress")]
        public IActionResult Update(AddressAddOrEditModel model)
        {
            var result = _business.Update(model);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete("DeleteAddress")]
        public IActionResult Delete(int id)
        {
            var address = _business.Get(id);
            if (address == null)
            {
                return BadRequest("This Address Not Found");
            }

            var result = _business.Delete(id);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("GetAllAddress")]
        public IActionResult GetAddress()
        {
            var results = _business.GetAll();
            return Ok(results);
        }
        [HttpPost("SearchAddress")]
        public IActionResult SearchAddress(AddressSearchModel sm, int recordCount)
        {
            var results = _business.Search(sm, out recordCount);
            if (results.MainResults.Count == 0)
            {
                return BadRequest("This Search No results");
            }
            return Ok(results);
        }
        [HttpGet("GetAddressInfo/{id}")]
        public IActionResult GetAddressInfo(int id)
        {
            var results = _business.Get(id);
            if (results == null)
            {
                return BadRequest("This Address Not Found");
            }
            return Ok(results);
        }
    }
}
