using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Currency;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ICurrencyRepository:IBaseRepositorySearchable<Currency,int,CurrencySearchModel,CurrencyComplexResults>
    {
        bool HasCurrency(string name);
    }
}
