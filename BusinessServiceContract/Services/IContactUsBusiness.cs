using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.ContactUs;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IContactUsBusiness
    {
        OperationResult Add(ContactUsAddEditModel model);
        OperationResult Update(ContactUsAddEditModel model);
        OperationResult Delete(int id);
        ContactUsAddEditModel Get(int id);
        List<ContactUs> GetAll();
        ContactUsComplexResults Search(ContactUsSearchModel sm, out int recordCount);
    }
}
