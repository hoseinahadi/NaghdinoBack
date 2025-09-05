using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Location;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface ILocationBusiness
    {
        OperationResult Add(LocationAddEditModel model);
        OperationResult Update(LocationAddEditModel model);
        OperationResult Delete(int id);
        LocationAddEditModel Get(int id);
        List<Location> GetAll();

    }
}
