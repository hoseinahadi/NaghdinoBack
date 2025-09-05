using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Employee;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IEmployeeRepository:IBaseRepositorySearchable<Employee,int,EmployeeSearchModel,EmployeeComplexResults>
    {
    }
}
