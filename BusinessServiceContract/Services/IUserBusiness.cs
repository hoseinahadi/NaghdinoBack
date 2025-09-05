using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.User;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IUserBusiness
    {
        OperationResult Add(UserAddEditModel model);
        OperationResult Update(UserAddEditModel model);
        OperationResult Delete(int id);
        UserComplexResults Get(int id);
        List<User> GetAll();
        UserComplexResults Search(UserSearchModel sm, out int recordCount);
        User GetUserByUserName(string userName);
    }
}
