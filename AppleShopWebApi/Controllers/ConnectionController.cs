using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class ConnectionController : Controller
    {
        private readonly IConnectionBusiness _connectionBusiness;

        public ConnectionController(IConnectionBusiness connectionBusiness)
        {
            _connectionBusiness = connectionBusiness;
        }
        [HttpPost("AddNewConnection")]
        public IActionResult AddNew(ConnectionAddOrEditModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _connectionBusiness.Add(model);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("UpdateConnection")]
        public IActionResult Update(ConnectionAddOrEditModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _connectionBusiness.Update(model);
                if (result.Success == true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }

        [HttpPost("SearchConnection")]
        public IActionResult Search(ConnectionSearchModel model, int recordCount)
        {

            var result = _connectionBusiness.Search(model, out recordCount);
            if (result.MainResults != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteConnection")]
        public IActionResult Delete(int id)
        {

            if (id != 0)
            {
                var category = _connectionBusiness.Get(id);
                if (category != null)
                {
                    var result = _connectionBusiness.Delete(id);
                    if (result.Success == true)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }

                return BadRequest("This Connection Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetConnection")]
        public IActionResult Get(int id)
        {
            var result = _connectionBusiness.Get(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }



        [HttpGet("GetAllConnection")]
        public IActionResult GetAll()
        {
            var result = _connectionBusiness.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

    }
}
