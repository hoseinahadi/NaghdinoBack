using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.OrderDiscount;
using DomainModel.DTO.OrderProduct;
using DomainModel.Models;


namespace DataAccessServicessContract.Services
{
    public interface IOrderProductRepository : IBaseRepositorySearchable<OrderProduct,int,OrderProduct,OrderProductComplexResult>
    {
        
    }
}
