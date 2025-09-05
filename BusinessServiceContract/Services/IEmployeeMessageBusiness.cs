using DomainModel.Assist;
using DomainModel.DTO.EmployeeDiscount;
using DomainModel.DTO.EmployeeMessage;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IEmployeeMessageBusiness
    {
        OperationResult Add(EmployeeMessage model);
        OperationResult Update(EmployeeMessage model);
        OperationResult Delete(int id);
        EmployeeMessage Get(int id);
        List<EmployeeMessage> GetAll();
        EmployeeMessageComplexResult Search(EmployeeMessage sm, out int recordCount);

    }
}
