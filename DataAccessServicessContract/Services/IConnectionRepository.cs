using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Connection;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IConnectionRepository:IBaseRepositorySearchable<Connection,int,ConnectionSearchModel,ConnectionComplexResult>
    {
    }
}
