using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.UserMessage;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IUserMessageRepository : IBaseRepositorySearchable<UserMessage,int, UserMessage, UserMessageComplexResult>
    {
        
    }
}
