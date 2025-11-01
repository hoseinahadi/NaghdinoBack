using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.ProductOrderReturn;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IProductOrderReturnRepository : IBaseRepositorySearchable<ProductOrderReturn,int, ProductOrderReturn, ProductOrderReturnComplexResult>
    {
        
    }
}
