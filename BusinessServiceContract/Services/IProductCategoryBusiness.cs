using DomainModel.Assist;
using DomainModel.DTO.ProductCart;
using DomainModel.DTO.ProductCategory;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IProductCategoryBusiness
    {
        OperationResult Add(ProductCategory model);
        OperationResult Update(ProductCategory model);
        OperationResult Delete(int id);
        ProductCategory Get(int id);
        List<ProductCategory> GetAll();
        ProductCategoryComplexResult Search(ProductCategory sm, out int recordCount);

    }
}
