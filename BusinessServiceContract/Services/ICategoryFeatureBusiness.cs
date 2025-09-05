using DomainModel.Assist;
using DomainModel.DTO.Access;
using DomainModel.DTO.CategoryFeature;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface ICategoryFeatureBusiness
    {
        OperationResult Add(CategoryFeature model);
        OperationResult Update(CategoryFeature model);
        OperationResult Delete(int id);
        CategoryFeature Get(int id);
        List<CategoryFeature> GetAll();
        CategoryFeatureComplexResult Search(CategoryFeature sm, out int recordCount);

    }
}
