using DomainModel.Assist;

using DomainModel.DTO.EmployeeDiscount;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IEmployeeDiscountBusiness
    {
        OperationResult Add(EmployeeDiscount model);
        OperationResult Update(EmployeeDiscount model);
        OperationResult Delete(int id);
        EmployeeDiscount Get(int id);
        List<EmployeeDiscount> GetAll();
        EmployeeDiscountComplexResult Search(EmployeeDiscount sm, out int recordCount);

    }
}
