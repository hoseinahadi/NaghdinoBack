using DomainModel.Assist;
using DomainModel.DTO.CategoryFeature;
using DomainModel.DTO.CountryDiscount;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface ICountryDiscountBusiness
    {
        OperationResult Add(CountryDiscount model);
        OperationResult Update(CountryDiscount model);
        OperationResult Delete(int id);
        CountryDiscount Get(int id);
        List<CountryDiscount> GetAll();
        CountryDiscountComplexResult Search(CountryDiscount sm, out int recordCount);

    }
}
