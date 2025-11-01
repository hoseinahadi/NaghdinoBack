using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Supplier;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ISupplierRepository:IBaseRepositorySearchable<Supplier,int,SupplierSearchModel,SupplierComplexResults>
    {
        bool HasSupplier(string name);
    }
}
