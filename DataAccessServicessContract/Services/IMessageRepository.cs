using DataAccessServicessContract.Services.Base;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IMessageRepository:IBaseRepository<Message,int>
    {
    }
}
