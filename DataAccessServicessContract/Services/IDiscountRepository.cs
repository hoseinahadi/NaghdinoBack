using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Discount;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IDiscountRepository:IBaseRepositorySearchable<Discount,int,DiscountSearchModel,DiscountComplexResults>
    {
    }
}
