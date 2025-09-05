using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Address;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IAddressRepository:IBaseRepositorySearchable<Address, int,AddressSearchModel,AddressComplexResult>
    {
        
    }
}
