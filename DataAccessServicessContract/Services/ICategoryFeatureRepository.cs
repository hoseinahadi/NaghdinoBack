using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.CategoryFeature;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ICategoryFeatureRepository : IBaseRepositorySearchable<CategoryFeature, int, CategoryFeature, CategoryFeatureComplexResult>
    {
        
    }
}
