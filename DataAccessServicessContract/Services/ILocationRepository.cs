using DataAccessServicessContract.Services.Base;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface ILocationRepository:IBaseRepository<Location,int>
    {
    }
}
