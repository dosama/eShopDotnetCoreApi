using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;

namespace eShopApi.Repository.Services
{
    public interface IUserReopsitory
    {
        Task<IEnumerable<Users>> ListAll();
        Task Add(Users item);
    }
}
