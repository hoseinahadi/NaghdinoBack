using DomainModel.Assist;
using DomainModel.DTO.OrderDiscount;
using DomainModel.DTO.OrderMessage;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IOrderMessageBusiness
    {
        OperationResult Add(OrderMessage model);
        OperationResult Update(OrderMessage model);
        OperationResult Delete(int id);
        OrderMessage Get(int id);
        List<OrderMessage> GetAll();
        OrderMessageComplexResult Search(OrderMessage sm, out int recordCount);

    }
}
