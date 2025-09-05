using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.ProductSupplier;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IProductSupplierRepository : IBaseRepositorySearchable<ProductSupplier,int, ProductSupplier, ProductSupplierComplexResult>
    {
        
    }
}
