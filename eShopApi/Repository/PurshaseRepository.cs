using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;
using eShopApi.Repository.Services;

namespace eShopApi.Repository
{
    public class PurshaseRepository : IPurshaseReopsitory
    {
        private readonly EShopContext _dbContext;

        public PurshaseRepository(EShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Purshases>> ListAll()
        {
            return _dbContext.Purshases.AsEnumerable();
        }

        public async Task Add(Purshases item)
        {
            _dbContext.Purshases.Add(item);
            _dbContext.SaveChanges();
        }

     

    }
}
