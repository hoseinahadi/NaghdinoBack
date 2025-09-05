using DataAccessServicessContract.Services.Base;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IPageRepository:IBaseRepository<Page,int>
    {
        bool HasPage(string name);
    }
}
