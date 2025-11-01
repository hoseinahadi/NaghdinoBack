using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.OpSystem;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IOpSystemBusiness
    {
        OperationResult Add(OpSystemAddEditModel model);
        OperationResult Update(OpSystemAddEditModel model);
        OperationResult Delete(int id);
        OpSystemAddEditModel Get(int id);
        List<OpSystem> GetAll();

    }
}
