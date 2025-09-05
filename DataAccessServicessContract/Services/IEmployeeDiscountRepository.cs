using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.EmployeeDiscount;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IEmployeeDiscountRepository : IBaseRepositorySearchable<EmployeeDiscount, int, EmployeeDiscount, EmployeeDiscountComplexResult>
    {
        
    }
}
