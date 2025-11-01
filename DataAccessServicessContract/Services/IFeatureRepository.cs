using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Feature;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IFeatureRepository:IBaseRepositorySearchable<Feature,int,FeatureSearchModel,FeatureComplexResults>
    {
        bool HasFeatureName(string name);
    }
}
