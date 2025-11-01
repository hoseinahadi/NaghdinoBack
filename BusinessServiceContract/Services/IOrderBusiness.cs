using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Order;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IOrderBusiness
    {
        OperationResult Add(OrderAddEditModel model);
        OperationResult Update(OrderAddEditModel model);
        OperationResult Delete(int id);
        OrderAddEditModel Get(int id);
        List<Order> GetAll();
        OrderComplexResults Search(OrderSearchModel sm, out int recordCount);
    }
}
