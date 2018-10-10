using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness.Services;
using eShopApi.Repository.Services;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness
{
    public class UserService:IUserService
    {
        private readonly IUserReopsitory _userReopsitory;
        public UserService(IUserReopsitory userReopsitory)
        {
            _userReopsitory = userReopsitory;


        }
        public async  Task<IEnumerable<UserViewModel>> GetAllUsers()
        {
            List<UserViewModel> usersResult = new List<UserViewModel>();
            var users = await _userReopsitory.ListAll();

            foreach (var user in users)
            {
                usersResult.Add(new UserViewModel{UserId = user.UserId,UserName = user.UserName});
            }

            return usersResult;

        }

        public async Task<UserViewModel> GetUserByUserName(string userName)
        {
            var users = await _userReopsitory.ListAll();
            var user = users?.FirstOrDefault(u => u.UserName == userName);
          
            return new UserViewModel { UserId = user.UserId, UserName = user.UserName };
            
        }

        public Task AddUser(UserViewModel item)
        {
            throw new NotImplementedException();
        }
    }
}
