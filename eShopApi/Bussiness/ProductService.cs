using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness.Services;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness
{
    public class ProductService:IProductService
    {
        public Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task AddProduct(ProductViewModel item)
        {
            throw new NotImplementedException();
        }
    }
}
