using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.SupplierImage;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ISupplierImageRepository : IBaseRepositorySearchable<SupplierImage,int, SupplierImage, SupplierImageComplexResult>
    {
        
    }
}
