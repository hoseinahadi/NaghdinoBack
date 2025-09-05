using DomainModel.Assist;
using DomainModel.DTO.Cart;
using DomainModel.DTO.Category;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Connection;

namespace BusinessServiceContract.Services
{
    public interface IConnectionBusiness
    {
        OperationResult Add(ConnectionAddOrEditModel model);
        OperationResult Update(ConnectionAddOrEditModel model);
        OperationResult Delete(int id);
        ConnectionAddOrEditModel Get(int id);
        List<Connection> GetAll();
        ConnectionComplexResult Search(ConnectionSearchModel sm, out int recordCount);
    }
}
