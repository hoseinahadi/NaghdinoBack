using DomainModel.Assist;
using DomainModel.DTO.Cart;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Category;
using DomainModel.DTO.Carrier;

namespace BusinessServiceContract.Services
{
    public interface ICategoryBusiness
    {
        OperationResult Add(CategoryAddOrEditModel model);
        OperationResult Update(CategoryAddOrEditModel model);
        OperationResult Delete(int id);
        CategoryAddOrEditModel Get(int id);
        List<Category> GetAll();
        CategoryComplexResult Search(CategorySearchModel sm, out int recordCount);
        bool HasCategory(string name);
        CategoryComplexResult GetParent(int id);
        CategoryComplexResult GetParents(int id);
        CategoryComplexResult GetChildren(int id);
        bool HasChildren(int id);
        bool HasProduct(int id);
        bool DuplicateName(string name);
        bool DuplicateName(string name, int id);
    }
}
