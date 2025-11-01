using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.User;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IUserRepository:IBaseRepositorySearchable<User,int,UserSearchModel,UserComplexResults>
    {
        bool HasDuplicateUserName (string userName);
        User GetUserByUserName (string userName);
    }
}
