using DataAccessServicessContract.Services.Base;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IGenderRepository:IBaseRepository<Gender,int>
    {
        bool HasGenderName(string name);
    }
}
