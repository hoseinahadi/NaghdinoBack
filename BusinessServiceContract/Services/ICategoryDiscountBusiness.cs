using DomainModel.Assist;
using DomainModel.DTO.Category;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.CategoryDiscount;


namespace BusinessServiceContract.Services
{
    public interface ICategoryDiscountBusiness
    {
        OperationResult Add(CategoryDiscount model);
        OperationResult Update(CategoryDiscount model);
        OperationResult Delete(int id);
        CategoryDiscount Get(int id);
        List<CategoryDiscount> GetAll();
        CategoryDiscountComplexResult Search(CategoryDiscount sm, out int recordCount);
    }
}
