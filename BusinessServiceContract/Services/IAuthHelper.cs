using DomainModel.DTO.User;

namespace BusinessServiceContract.Services
{
    public interface IAuthHelper
    {
        void Signin(UserInfo account);
        void SignOut();
        UserInfo GetCurrentUserInfo();
    }
}