using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;
using eShopApi.Repository.Services;

namespace eShopApi.Repository
{
    public class ProductRepository: IProductReopsitory
    {
        private readonly EShopContext _dbContext;

        public ProductRepository(EShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Products>> ListAll()
        {
            return  _dbContext.Products.AsEnumerable();
        }

        public async Task Add(Products character)
        {
            _dbContext.Products.Add(character);
            _dbContext.SaveChanges();
        }

     

    }
}
