using BusinessServiceContract.Services;
using DomainModel.DTO.Address;
using DomainModel.DTO.Carrier;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class CarrierController : Controller
    {
        private readonly ICarrierBusiness _carrierBusiness;

        public CarrierController(ICarrierBusiness carrierBusiness)
        {
            _carrierBusiness = carrierBusiness;
        }
        [HttpPost("AddNewCarrier")]
        public IActionResult AddNew(CarrierAddEditModel model)
        {
            var result = _carrierBusiness.Add(model);
            if (result.Success==true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
        [HttpGet("UpdateCarrierInfo")]
        public IActionResult Update(int id)
        {
            var model = _carrierBusiness.Get(id);
            if (model != null)
            {
                return Ok(model);
            }

            return BadRequest(model);
        }

        [HttpPost("UpdateCarrier")]
        public IActionResult Update(CarrierAddEditModel model)
        {
            var result = _carrierBusiness.Update(model);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete("DeleteCarrier")]
        public IActionResult Delete(int id)
        {
            var address = _carrierBusiness.Get(id);
            if (address == null)
            {
                return BadRequest("This Carrier Not Found");
            }

            var result = _carrierBusiness.Delete(id);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("GetAllCarrier")]
        public IActionResult GetAddress()
        {
            var results = _carrierBusiness.GetAll();
            return Ok(results);
        }
        [HttpPost("SearchCarrier")]
        public IActionResult SearchAddress(CarrierSearchModel sm, int recordCount)
        {
            var results = _carrierBusiness.Search(sm, out recordCount);
            if (results.MainResults.Count == 0)
            {
                return BadRequest("This Search No results");
            }
            return Ok(results);
        }
        [HttpGet("GetCarrierInfo/{id}")]
        public IActionResult GetAddressInfo(int id)
        {
            var results = _carrierBusiness.Get(id);
            if (results == null)
            {
                return BadRequest("This Address Not Found");
            }
            return Ok(results);
        }
    }
}
