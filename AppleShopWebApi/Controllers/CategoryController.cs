using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryBusiness _categoryBusiness;

        public CategoryController(ICategoryBusiness categoryBusiness)
        {
            _categoryBusiness = categoryBusiness;
        }
        [HttpPost("AddNewCategory")]
        //[Authorize]
        public IActionResult AddNew(CategoryAddOrEditModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ParentId!=0)
                {
                    var parent = _categoryBusiness.Get(model.ParentId);
                    if (parent != null)
                    {
                        return NotFound(parent);
                    }
                }
                var result = _categoryBusiness.Add(model);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("UpdateCategory")]
        [Authorize]

        public IActionResult Update(CategoryAddOrEditModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ParentId != 0)
                {
                    var parent = _categoryBusiness.Get(model.ParentId);
                    if (parent != null)
                    {
                        return NotFound(parent);
                    }
                }
                var result = _categoryBusiness.Update(model);
                if (result.Success == true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }

        [HttpPost("SearchCategory")]
        public IActionResult Search(CategorySearchModel model ,int recordCount)
        {
            
            var result = _categoryBusiness.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult Delete(int id)
        {
            
            if (id!=0)
            {
                var category = _categoryBusiness.Get(id);
                if (category != null)
                {
                    var result = _categoryBusiness.Delete(id);
                    if (result.Success == true)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }

                return BadRequest("This Category Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetCategory")]
        public IActionResult Get(int id)
        {
            var result = _categoryBusiness.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllCategory")]
        public IActionResult GetAll()
        {
            var result = _categoryBusiness.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

    }
}
