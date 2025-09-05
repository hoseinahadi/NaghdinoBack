using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.GuestUser;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IGuestUserBusiness
    {
        OperationResult Add(GuestUserAddEditModel model);
        OperationResult Update(GuestUserAddEditModel model);
        OperationResult Delete(int id);
        GuestUserAddEditModel Get(int id);
        List<GuestUser> GetAll();
        GuestUserComplexResults Search(GuestUserSearchModel sm, out int recordCount);
    }
}
