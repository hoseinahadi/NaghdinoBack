using DataAccessServicessContract.Services.Base;
using DomainModel.DTO.Image;
using DomainModel.Models;

namespace DataAccessServicessContract.Services
{
    public interface IImageRepository:IBaseRepositorySearchable<Image,int,ImageSearchModel,ImageComplexResults>
    {
    }
}
