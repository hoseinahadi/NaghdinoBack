using DomainModel.Assist;
using DomainModel.DTO.ProductCategory;
using DomainModel.DTO.ProductDiscount;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IProductDiscountBusiness
    {
        OperationResult Add(ProductDiscount model);
        OperationResult Update(ProductDiscount model);
        OperationResult Delete(int id);
        ProductDiscount Get(int id);
        List<ProductDiscount> GetAll();
        ProductDiscountComplexResult Search(ProductDiscount sm, out int recordCount);

    }
}
