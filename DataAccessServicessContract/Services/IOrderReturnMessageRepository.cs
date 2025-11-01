using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.OrderReturnMessage;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IOrderReturnMessageRepository : IBaseRepositorySearchable<OrderReturnMessage,int, OrderReturnMessage, OrderReturnMessageComplexResult>
    {
        
    }
}
