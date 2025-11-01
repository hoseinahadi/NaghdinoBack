using DomainModel.Assist;
using DomainModel.DTO.OrderProduct;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IOrderProductBusiness
    {
        OperationResult Add(OrderProduct model);
        OperationResult Update(OrderProduct model);
        OperationResult Delete(int id);
        OrderProduct Get(int id);
        List<OrderProduct> GetAll();
        OrderProductComplexResult Search(OrderProduct sm, out int recordCount);
    }
}
