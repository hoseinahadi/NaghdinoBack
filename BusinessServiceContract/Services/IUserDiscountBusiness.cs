using DomainModel.Assist;
using DomainModel.DTO.SupplierImage;
using DomainModel.DTO.UserDiscount;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IUserDiscountBusiness
    {
        OperationResult Add(UserDiscount model);
        OperationResult Update(UserDiscount model);
        OperationResult Delete(int id);
        UserDiscount Get(int id);
        List<UserDiscount> GetAll();
        UserDiscountComplexResult Search(UserDiscount sm, out int recordCount);

    }
}
