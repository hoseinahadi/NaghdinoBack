using DomainModel.Assist;
using DomainModel.DTO.ProductOrderReturn;
using DomainModel.DTO.ProductSupplier;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IProductSupplierBusiness
    {
        OperationResult Add(ProductSupplier model);
        OperationResult Update(ProductSupplier model);
        OperationResult Delete(int id);
        ProductSupplier Get(int id);
        List<ProductSupplier> GetAll();
        ProductSupplierComplexResult Search(ProductSupplier sm, out int recordCount);

    }
}
