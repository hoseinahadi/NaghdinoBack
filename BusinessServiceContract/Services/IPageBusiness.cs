using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Page;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IPageBusiness
    {
        OperationResult Add(PageAddEditModel model);
        OperationResult Update(PageAddEditModel model);
        OperationResult Delete(int id);
        PageAddEditModel Get(int id);
        List<Page> GetAll();

    }
}
