using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Discount;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IDiscountBusiness
    {
        OperationResult Add(DiscountAddOrEditModel model);
        OperationResult Update(DiscountAddOrEditModel model);
        OperationResult Delete(int id);
        DiscountAddOrEditModel Get(int id);
        List<Discount> GetAll();
        DiscountComplexResults Search(DiscountSearchModel sm, out int recordCount);
    }
}
