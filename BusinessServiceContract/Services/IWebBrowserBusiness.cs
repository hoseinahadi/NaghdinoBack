using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.WbBrowser;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IWebBrowserBusiness
    {
        OperationResult Add(WebBrowserAddEditModel model);
        OperationResult Update(WebBrowserAddEditModel model);
        OperationResult Delete(int id);
        WebBrowserAddEditModel Get(int id);
        List<WebBrowser> GetAll();
    }
}
