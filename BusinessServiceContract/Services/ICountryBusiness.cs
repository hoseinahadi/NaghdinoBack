using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Country;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface ICountryBusiness
    {
        OperationResult Add(CountryAddOeEditModel model);
        OperationResult Update(CountryAddOeEditModel model);
        OperationResult Delete(int id);
        CountryAddOeEditModel Get(int id);
        List<Country> GetAll();
        CountryComplexResults Search(CountrySearchModel sm, out int recordCount);
    }
}
