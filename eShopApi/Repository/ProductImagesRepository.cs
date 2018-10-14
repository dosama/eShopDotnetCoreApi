using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;
using eShopApi.Repository.Services;

namespace eShopApi.Repository
{
    public class ProductImagesRepository : IProductImagesReopsitory
    {
        private readonly EShopContext _dbContext;

        public ProductImagesRepository(EShopContext dbContext)
        {
            _dbContext = dbContext;
        }

     
        public  async Task<IEnumerable<ProductsImages>> ListByProductId(Guid productId)
         {
             return _dbContext.ProductsImages.Where(p => p.ProductId== productId).ToList();
         }

        public async Task Add(ProductsImages item)
        {
            _dbContext.ProductsImages.Add(item);
            _dbContext.SaveChanges();
        }

        public async Task<IEnumerable<ProductsImages>> ListAll()
        {
            return _dbContext.ProductsImages.AsEnumerable();
        }
    }
}
