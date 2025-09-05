using System.Collections.Generic;
using System.IO;
using AppleShopWebApi.Model;
using BusinessServiceContract.Services;
using DomainModel.DTO.Category;
using DomainModel.DTO.Connection;
using DomainModel.DTO.ContactUs;
using DomainModel.DTO.Currency;
using DomainModel.DTO.Delivery;
using DomainModel.DTO.Discount;
using DomainModel.DTO.Image;
using Framework.ImageUtility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageBusiness _business;
        private readonly IHostingEnvironment env;

        public ImageController(IImageBusiness business, IHostingEnvironment env)
        {
            _business = business;
            this.env = env;
        }
        [HttpPost("AddNewImage")]
        public IActionResult AddNew(ImageViewModel model)
        {
            var fileName = System.IO.Path.GetFileName(model.Picture.FileName);
            if (!fileName.IsValidFileName())
            {
                return BadRequest("This image Name Not True");
            }
            fileName = fileName.ToUniqueFileName();
            var savingPath = env.WebRootPath + @"/Images/" + fileName;
            var file = env.WebRootPath + @"/Images/";
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            FileStream fs = new FileStream(savingPath, FileMode.Create);
            model.Picture.CopyTo(fs);
            fs.Close();

            var addModel = new ImageAddOrEditModel
            {
                ProductId = model.ProductId,
                UserId = model.UserId,
                EmployeeId = model.EmployeeId,
                ImageCode = model.ImageCode,
                ImageId = model.ImageId,
                ImageName = fileName,
                ImageUrl = savingPath
            };

            if (ModelState.IsValid)
            {
                var result = _business.Add(addModel);
                if (result.Success==true)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Model Not Valid");

        }
        [HttpPost("AddNewMultipleImage")]
        public IActionResult MultipleImage(object obj)
        {
            var y  = obj.GetType().GetMethod("MyFunction").Invoke(obj, null);
            var result = "";
            //foreach (var item in equatable)
            //{
            //    var x = AddNew(item);
            //    result += x + ",";
            //}
            return Json(result);
        }



        [HttpPost("UpdateImage")]
        public IActionResult Update(ImageAddOrEditModel model)
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

        [HttpPost("SearchImage")]
        public IActionResult Search(ImageSearchModel model ,int recordCount)
        {
            
            var result = _business.Search(model,out recordCount);
            if (result.MainResults!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("DeleteImage")]
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

                return BadRequest("This Image Not Found");
            }

            return BadRequest("Select Id ");
        }

        [HttpGet("GetImage")]
        public IActionResult Get(int id)
        {
            var result = _business.Get(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        [HttpGet("GetAllImage")]
        public IActionResult GetAll()
        {
            var result = _business.GetAll();
            
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("Image is Null");
        }

    }
}
