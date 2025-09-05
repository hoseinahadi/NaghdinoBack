using DomainModel.Assist;
using DomainModel.DTO.OrderReturnMessage;
using DomainModel.DTO.ProductCart;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IProductCartBusiness
    {
        OperationResult Add(ProductCart model);
        OperationResult Update(ProductCart model);
        OperationResult Delete(int id);
        ProductCart Get(int id);
        List<ProductCart> GetAll();
        ProductCartComplexResult Search(ProductCart sm, out int recordCount);

    }
}
