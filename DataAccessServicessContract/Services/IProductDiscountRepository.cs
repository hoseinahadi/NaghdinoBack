using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.ProductDiscount;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IProductDiscountRepository : IBaseRepositorySearchable<ProductDiscount,int, ProductDiscount, ProductDiscountComplexResult>
    {
        
    }
}
