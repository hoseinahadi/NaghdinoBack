using DomainModel.Assist;
using DomainModel.DTO.UserFavorite;
using DomainModel.DTO.UserMessage;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IUserMessageBusiness
    {
        OperationResult Add(UserMessage model);
        OperationResult Update(UserMessage model);
        OperationResult Delete(int id);
        UserMessage Get(int id);
        List<UserMessage> GetAll();
        UserMessageComplexResult Search(UserMessage sm, out int recordCount);

    }
}
