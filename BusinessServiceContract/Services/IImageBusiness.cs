using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Image;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IImageBusiness
    {
        OperationResult Add(ImageAddOrEditModel model);
        OperationResult Update(ImageAddOrEditModel model);
        OperationResult Delete(int id);
        ImageAddOrEditModel Get(int id);
        List<Image> GetAll();
        ImageComplexResults Search(ImageSearchModel sm, out int recordCount);
    }
}
