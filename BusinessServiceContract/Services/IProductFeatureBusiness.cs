using DomainModel.Assist;
using DomainModel.DTO.ProductDiscount;
using DomainModel.DTO.ProductFeature;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IProductFeatureBusiness
    {
        OperationResult Add(ProductFeature model);
        OperationResult Update(ProductFeature model);
        OperationResult Delete(int id);
        ProductFeature Get(int id);
        List<ProductFeature> GetAll();
        ProductFeatureComplexResult Search(ProductFeature sm, out int recordCount);

    }
}
