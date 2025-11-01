using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.GuestUserMessage;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IGuestUserMessageRepository : IBaseRepositorySearchable<GuestUserMessage,int, GuestUserMessage, GuestUserMessageComplexResult>
    {
        
    }
}
