using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Cart;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ICartRepository:IBaseRepositorySearchable<Cart,int,CartSearchModel,CartComplexResult>
    {

    }
}
