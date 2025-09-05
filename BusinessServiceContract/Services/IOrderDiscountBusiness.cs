using DomainModel.Assist;
using DomainModel.DTO.GuestUserMessage;
using DomainModel.DTO.OrderDiscount;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IOrderDiscountBusiness
    {
        OperationResult Add(OrderDiscount model);
        OperationResult Update(OrderDiscount model);
        OperationResult Delete(int id);
        OrderDiscount Get(int id);
        List<OrderDiscount> GetAll();
        OrderDiscountComplexResult Search(OrderDiscount sm, out int recordCount);

    }
}
