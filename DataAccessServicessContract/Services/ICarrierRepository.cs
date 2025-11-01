using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Carrier;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ICarrierRepository:IBaseRepositorySearchable<Carrier,int,CarrierSearchModel,CarrierComplexResults>
    {
        
    }
}
