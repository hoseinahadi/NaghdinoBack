using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Order;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IOrderRepository:IBaseRepositorySearchable<Order,int,OrderSearchModel,OrderComplexResults>
    {
    }
}
