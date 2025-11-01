using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessServiceContract.Services;
using DataAccessServicessContract.Services;
using DomainModel.Assist;
using DomainModel.DTO.Tax;
using DomainModel.DTO.User;
using DomainModel.Models;

namespace Business.IMP
{
    public class UserBusiness:IUserBusiness
    {
        private readonly IUserRepository repo;

        public UserBusiness(IUserRepository repo)
        {
            this.repo = repo;
        }
        private User ToModel(UserAddEditModel addOrEdit)
        {
            return new User
            {
                Active = addOrEdit.Active,
                AddDate = addOrEdit.AddDate,
                BirthDay = addOrEdit.BirthDay,
                Email = addOrEdit.Email,
                FirstName = addOrEdit.FirstName,
                LastName = addOrEdit.LastName,
                GenderId = addOrEdit.GenderId,
                LastPassword = addOrEdit.LastPassword,
                Password = addOrEdit.Password,
                Phone = addOrEdit.Phone,
                UserId = addOrEdit.UserId,
                UserName = addOrEdit.UserName,
                RoleId = addOrEdit.RoleId,


                
            };
        }
        private UserAddEditModel ToAddEditModel(User model)
        {
            return new UserAddEditModel
            {
                Active = model.Active,
                AddDate = model.AddDate,
                BirthDay = model.BirthDay,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                GenderId = model.GenderId,
                LastPassword = model.LastPassword,
                Password = model.Password,
                Phone = model.Phone,
                UserId = model.UserId,
                UserName = model.UserName,
                RoleId = model.RoleId,

                
            };
        }
        private UserSearchResult ToSearchResult(User model)
        {
            return new UserSearchResult
            {
                Active = model.Active,
                AddDate = model.AddDate,
                BirthDay = model.BirthDay,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                GenderId = model.GenderId,
                LastPassword = model.LastPassword,
                Password = model.Password,
                Phone = model.Phone,
                UserId = model.UserId,
                UserName = model.UserName,
            };
        }
        public OperationResult Add(UserAddEditModel model)
        {
            return repo.Add(ToModel(model));
        }

        public OperationResult Update(UserAddEditModel model)
        {
            return repo.Update(ToModel(model));
        }

        public OperationResult Delete(int id)
        {
            return repo.Delete(id);
        }

        public UserComplexResults Get(int id)
        {
            OperationResult op = new OperationResult("Get");
            List<string> errors = new List<string>();
            List<UserSearchResult> user = new List<UserSearchResult>();
            var model = repo.Get(id);
            if (model!=null)
            {
                user.Add(ToSearchResult(model));
                return new UserComplexResults
                {
                    MainResults = user,
                    Errors = null
                };

            }
            errors.Add("This User Not Found");
            return new UserComplexResults
            {
                MainResults = null,
                Errors = errors
            };
            
        }

        public List<User> GetAll()
        {
            return repo.GetAll();
        }

        public UserComplexResults Search(UserSearchModel sm, out int recordCount)
        {
            return repo.Search(sm, out recordCount);
        }

        public User GetUserByUserName(string userName)
        {
            return repo.GetUserByUserName(userName);
        }
    }
}
