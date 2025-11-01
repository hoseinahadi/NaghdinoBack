using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Country;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ICountryRepository:IBaseRepositorySearchable<Country,int,CountrySearchModel,CountryComplexResults>
    {
        bool DuplicateCountry(string name);
    }
}
