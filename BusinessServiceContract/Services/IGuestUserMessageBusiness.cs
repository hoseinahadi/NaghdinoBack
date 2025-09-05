using DomainModel.Assist;
using DomainModel.DTO.EmployeeMessage;
using DomainModel.DTO.GuestUserMessage;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IGuestUserMessageBusiness
    {
        OperationResult Add(GuestUserMessage model);
        OperationResult Update(GuestUserMessage model);
        OperationResult Delete(int id);
        GuestUserMessage Get(int id);
        List<GuestUserMessage> GetAll();
        GuestUserMessageComplexResult Search(GuestUserMessage sm, out int recordCount);

    }
}
