using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.CountryDiscount;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ICountryDiscountRepository : IBaseRepositorySearchable<CountryDiscount,int,CountryDiscount,CountryDiscountComplexResult>
    {
        
    }
}
