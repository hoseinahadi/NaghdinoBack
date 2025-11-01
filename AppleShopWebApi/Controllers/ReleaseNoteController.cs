using System.Collections.Generic;
using BusinessServiceContract.Services;
using DataAccessServicessContract.Services;
using DomainModel.DTO.Category;
using DomainModel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Controllers
{
    public class ReleaseNoteController : Controller
    {
        

        [HttpPost("ReleaseNote")]
        [Authorize]
        public IActionResult ReleaseNote()
        {
            var result = new List<string>()
            {
                "اضافه شدن بخش گزارشات هزینه و درآمد",
                "اضافه شدن بخش قیمت ارز ، سکه و طلا ،ارز دیجیتال ",
                "اضافه شدن فیلتر جست و جو در لیست تراکنش",
                "بهبود تجربه کاربری و رفع برخی مشکلات ",
            };

            return Ok(result);

        }
        

       

    }
}
