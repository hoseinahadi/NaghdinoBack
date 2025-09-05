using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.OrderDiscount;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IOrderDiscountRepository : IBaseRepositorySearchable<OrderDiscount,int,OrderDiscount,OrderDiscountComplexResult>
    {
        
    }
}
