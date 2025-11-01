using DomainModel.Assist;
using DomainModel.DTO.OrderMessage;
using DomainModel.DTO.OrderReturnMessage;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IOrderReturnMessageBusiness
    {
        OperationResult Add(OrderReturnMessage model);
        OperationResult Update(OrderReturnMessage model);
        OperationResult Delete(int id);
        OrderReturnMessage Get(int id);
        List<OrderReturnMessage> GetAll();
        OrderReturnMessageComplexResult Search(OrderReturnMessage sm, out int recordCount);

    }
}
