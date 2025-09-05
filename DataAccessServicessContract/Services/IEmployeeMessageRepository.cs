using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.EmployeeMessage;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IEmployeeMessageRepository : IBaseRepositorySearchable<EmployeeMessage, int, EmployeeMessage, EmployeeMessageComplexResult>
    {
        
    }
}
