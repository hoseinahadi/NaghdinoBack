using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Delivery;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IDeliveryBusiness
    {
        OperationResult Add(DeliveryAddOrEditModel model);
        OperationResult Update(DeliveryAddOrEditModel model);
        OperationResult Delete(int id);
        DeliveryAddOrEditModel Get(int id);
        List<Delivery> GetAll();
        DeliveryComplexResults Search(DeliverySearchModel sm, out int recordCount);
    }
}
