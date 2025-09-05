using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.OrderMessage;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IOrderMessageRepository : IBaseRepositorySearchable<OrderMessage,int,OrderMessage,OrderMessageComplexResult>
    {
        
    }
}
