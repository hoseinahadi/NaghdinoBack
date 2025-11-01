using DomainModel.Assist;
using DomainModel.DTO.Carrier;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DTO.Cart;

namespace BusinessServiceContract.Services
{
    public interface ICartBusiness
    {
        OperationResult Add(CartAddOrEditModel model);
        OperationResult Update(CartAddOrEditModel model);
        OperationResult Delete(int id);
        CartAddOrEditModel Get(int id);
        List<Cart> GetAll();
    }
}
