using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.ProductCategory;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IProductCategoryRepository : IBaseRepositorySearchable<ProductCategory,int, ProductCategory, ProductCategoryComplexResult>
    {
    }
}
