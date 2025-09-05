using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.OrderReturn;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IOrderReturnBusiness
    {
        OperationResult Add(OrderReturnAddEditModel model);
        OperationResult Update(OrderReturnAddEditModel model);
        OperationResult Delete(int id);
        OrderReturnAddEditModel Get(int id);
        List<OrderReturn> GetAll();
        OrderReturnComplexResults Search(OrderReturnSearchModel sm, out int recordCount);
    }
}
