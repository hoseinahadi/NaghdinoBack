using DomainModel.Assist;
using DomainModel.DTO.User;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IAccountRepository
    {
        UserInfo GetUserInfo(string userName);
        User GetFullInfo(string userName);
        OperationResult RegisterNewUser(User u);
        bool CheckIfUserHasAccess(CheckPermission per);
        User GetUserWithPhone(string number);
    }
}
