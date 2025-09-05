using DomainModel.Assist;
using DomainModel.DTO.ProductSupplier;
using DomainModel.DTO.SupplierImage;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface ISupplierImageBusiness
    {
        OperationResult Add(SupplierImage model);
        OperationResult Update(SupplierImage model);
        OperationResult Delete(int id);
        SupplierImage Get(int id);
        List<SupplierImage> GetAll();
        SupplierImageComplexResult Search(SupplierImage sm, out int recordCount);

    }
}
