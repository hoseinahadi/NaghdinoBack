using DomainModel.Assist;
using DomainModel.DTO.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Product;
using DomainModel.Models;

namespace BusinessServiceContract.Services
{
    public interface IProductBusiness
    {
        OperationResult Add(ProductAddEditModel model);
        OperationResult Update(ProductAddEditModel model);
        OperationResult Delete(int id);
        ProductAddEditModel Get(int id);
        List<Product> GetAll();
        ProductComplexResults Search(ProductSearchModel sm, out int recordCount);
    }
}
