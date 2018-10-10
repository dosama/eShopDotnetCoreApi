using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;
using eShopApi.Repository.Services;

namespace eShopApi.Repository
{
    public class UserRepository: IUserReopsitory
    {
        private readonly EShopContext _dbContext;

        public UserRepository(EShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Users>> ListAll()
        {
            return _dbContext.Users.AsEnumerable();
        }

        public async Task Add(Users item)
        {
            _dbContext.Users.Add(item);
            _dbContext.SaveChanges();
        }

     

    }
}
