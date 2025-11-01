using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.UserFavorite;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IUserFavoriteRepository : IBaseRepositorySearchable<UserFavorite,int, UserFavorite, UserFavoriteComplexResult>
    {
        
    }
}
