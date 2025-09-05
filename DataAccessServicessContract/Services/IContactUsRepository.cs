using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.ContactUs;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IContactUsRepository:IBaseRepositorySearchable<ContactUs,int,ContactUsSearchModel,ContactUsComplexResults>
    {
        
    }
}
