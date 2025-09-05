using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.ProductFeature;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IProductFeatureRepository : IBaseRepositorySearchable<ProductFeature,int, ProductFeature, ProductFeatureComplexResult>
    {
        
    }
}
