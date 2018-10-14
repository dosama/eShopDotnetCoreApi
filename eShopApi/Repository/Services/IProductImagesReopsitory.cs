using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;

namespace eShopApi.Repository.Services
{
    public interface IProductImagesReopsitory
    {
        Task<IEnumerable<ProductsImages>> ListAll();

        Task<IEnumerable<ProductsImages>> ListByProductId(Guid productId);
        Task Add(ProductsImages item);
    }
}
