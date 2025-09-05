using DomainModel.Assist;
using DomainModel.DTO.UserDiscount;
using DomainModel.DTO.UserFavorite;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceContract.Services
{
    public interface IUserFavoriteBusiness
    {
        OperationResult Add(UserFavorite model);
        OperationResult Update(UserFavorite model);
        OperationResult Delete(int id);
        UserFavorite Get(int id);
        List<UserFavorite> GetAll();
        UserFavoriteComplexResult Search(UserFavorite sm, out int recordCount);

    }
}
