using System.Collections.Generic;
using System.Threading.Tasks;
using eShopApi.Models;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetAllUsers();
        Task AddUser(UserViewModel item);
        Task<UserViewModel> GetUserByUserName(string userName);
    }
}
