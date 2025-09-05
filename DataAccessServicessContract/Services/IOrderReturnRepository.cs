using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.OrderReturn;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IOrderReturnRepository:IBaseRepositorySearchable<OrderReturn,int,OrderReturnSearchModel,OrderReturnComplexResults>
    {
    }
}
