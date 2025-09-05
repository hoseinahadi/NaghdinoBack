using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.UserDiscount;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IUserDiscountRepository : IBaseRepositorySearchable<UserDiscount,int,UserDiscount,UserDiscountComplexResult>
    {
        
    }
}
