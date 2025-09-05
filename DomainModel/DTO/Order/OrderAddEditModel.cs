using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.DTO.Order
{
    public class OrderAddEditModel
    {
        public int OrderId { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }

        public int CurrencyId { get; set; }

        public int OrderHistoryId { get; set; }
        public int EmployeeId { get; set; }

        public string Payment { get; set; }
        [Required(ErrorMessage = " شماره ثابت فروشگاه را وارد کنید ")]
        [Display(Name = " شماره ثابت فروشگاه ")]
        public string ShoppingPhone { get; set; }
        public string SecureKey { get; set; }
        public int ProductCount { get; set; }


    }
}
