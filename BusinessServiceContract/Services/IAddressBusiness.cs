using DomainModel.Assist;
using DomainModel.DTO.Access;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Address;

namespace BusinessServiceContract.Services
{
    public interface IAddressBusiness
    {
        OperationResult Add(AddressAddOrEditModel model);
        OperationResult Update(AddressAddOrEditModel model);
        OperationResult Delete(int id);
        AddressAddOrEditModel Get(int id);
        List<Address> GetAll();
        AddressComplexResult Search(AddressSearchModel sm, out int recordCount);
    }
}
