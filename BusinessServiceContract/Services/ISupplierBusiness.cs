using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Supplier;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface ISupplierBusiness
    {
        OperationResult Add(SupplierAddEditModel model);
        OperationResult Update(SupplierAddEditModel model);
        OperationResult Delete(int id);
        SupplierAddEditModel Get(int id);
        List<Supplier> GetAll();
        SupplierComplexResults Search(SupplierSearchModel sm, out int recordCount);
    }
}
