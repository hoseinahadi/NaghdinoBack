using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Feature;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IFeatureBusiness
    {
        OperationResult Add(FeatureAddEditModel model);
        OperationResult Update(FeatureAddEditModel model);
        OperationResult Delete(int id);
        FeatureAddEditModel Get(int id);
        List<Feature> GetAll();
        FeatureComplexResults Search(FeatureSearchModel sm, out int recordCount);
    }
}
