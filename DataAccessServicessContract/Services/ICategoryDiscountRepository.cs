using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.CategoryDiscount;
using DomainModel.DTO.EmployeeDiscount;
using DomainModel.DTO.OrderProduct;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ICategoryDiscountRepository : IBaseRepositorySearchable<CategoryDiscount, int, CategoryDiscount, CategoryDiscountComplexResult>
    {
        
    }
}
