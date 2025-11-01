using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppleShopWebApi.Model
{
    public class ImageViewModel
    {
        public int ImageId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? EmployeeId { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = " نام عکس را وارد کنید ")]
        [Display(Name = " نام عکس ")]
        public string ImageName { get; set; }
        public string ImageCode { get; set; }
        
        public IFormFile Picture { get; set; }
    }
}
