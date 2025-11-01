using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Product;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IProductRepository:IBaseRepositorySearchable<Product,int,ProductSearchModel,ProductComplexResults>
    {
        bool HasProduct(string name);
    }
}
