using System.Collections.Generic;
using System.Threading.Tasks;
using eShopApi.Models;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();
        Task AddProduct(ProductViewModel item);
    }
}
