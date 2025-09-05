using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.GuestUser;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IGuestUserRepository:IBaseRepositorySearchable<GuestUser,int,GuestUserSearchModel,GuestUserComplexResults>
    {
    }
}
