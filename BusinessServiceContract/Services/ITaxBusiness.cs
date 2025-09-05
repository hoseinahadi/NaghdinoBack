using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Tax;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface ITaxBusiness
    {
        OperationResult Add(TaxAddEditModel model);
        OperationResult Update(TaxAddEditModel model);
        OperationResult Delete(int id);
        TaxAddEditModel Get(int id);
        List<Tax> GetAll();
        TaxComplexResults Search(TaxSearchModel sm, out int recordCount);
    }
}
