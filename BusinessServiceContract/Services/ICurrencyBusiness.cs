using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Currency;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface ICurrencyBusiness
    {
        OperationResult Add(CurrencyAddOrEditModel model);
        OperationResult Update(CurrencyAddOrEditModel model);
        OperationResult Delete(int id);
        CurrencyAddOrEditModel Get(int id);
        List<Currency> GetAll();
        CurrencyComplexResults Search(CurrencySearchModel sm, out int recordCount);
    }
}
