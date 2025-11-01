using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Gender;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IGenderBusiness
    {
        OperationResult Add(GenderAddEditModel model);
        OperationResult Update(GenderAddEditModel model);
        OperationResult Delete(int id);
        GenderAddEditModel Get(int id);
        List<Gender> GetAll();

    }
}
