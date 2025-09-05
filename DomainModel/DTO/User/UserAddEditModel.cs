using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.DTO.User
{
    public class UserAddEditModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int GenderId { get; set; }
        [Required(ErrorMessage = " نام کاربری را وارد کنید ")]
        [Display(Name = " نام کاربری  ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = " نام را وارد کنید")]
        [Display(Name = " نام ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = " نام خانوادگی را وارد کنید")]
        [Display(Name = " نام خانوادگی ")]
        public string LastName { get; set; }
        [Required(ErrorMessage = " کلمه عبور را وارد کنید ")]
        [Display(Name = " کلمه عبور ")]
        public string Password { get; set; }
        public string LastPassword { get; set; }
        [Required(ErrorMessage = " ایمیل را وارد کنید ")]
        [Display(Name = " ایمیل ")]
        public string Email { get; set; }
        [Required(ErrorMessage = " شماره تلفن را وارد کنید")]
        [Display(Name = " شماره تلفن ")]
        public string Phone { get; set; }
        public bool Active { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime BirthDay { get; set; }
        
        

    }
}
