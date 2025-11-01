using DataAccessServicessContract.Services.Base;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IWebBrowserRepository:IBaseRepository<WebBrowser,int>
    {
        bool HasName(string name);
    }
}
