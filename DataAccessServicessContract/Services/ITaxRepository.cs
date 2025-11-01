using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Tax;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ITaxRepository:IBaseRepositorySearchable<Tax,int,TaxSearchModel,TaxComplexResults>
    {
        bool HasTax(string name);
    }
}
