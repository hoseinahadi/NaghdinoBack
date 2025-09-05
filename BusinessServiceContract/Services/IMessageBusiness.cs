using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Message;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IMessageBusiness
    {
        OperationResult Add(MessageAddEditModel model);
        OperationResult Update(MessageAddEditModel model);
        OperationResult Delete(int id);
        MessageAddEditModel Get(int id);
        List<Message> GetAll();
    }
}
