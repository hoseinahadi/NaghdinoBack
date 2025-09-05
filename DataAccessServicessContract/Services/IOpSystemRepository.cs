using DataAccessServicessContract.Services.Base;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IOpSystemRepository:IBaseRepository<OpSystem,int>
    {
        bool HasOpSystem(string name);
    }
}
