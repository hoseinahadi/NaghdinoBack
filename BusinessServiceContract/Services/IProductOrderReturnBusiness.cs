using DomainModel.Assist;
using DomainModel.DTO.ProductFeature;
using DomainModel.DTO.ProductOrderReturn;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IProductOrderReturnBusiness
    {
        OperationResult Add(ProductOrderReturn model);
        OperationResult Update(ProductOrderReturn model);
        OperationResult Delete(int id);
        ProductOrderReturn Get(int id);
        List<ProductOrderReturn> GetAll();
        ProductOrderReturnComplexResult Search(ProductOrderReturn sm, out int recordCount);

    }
}
