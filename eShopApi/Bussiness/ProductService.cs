using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness.Services;
using eShopApi.Repository.Services;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness
{
    public class ProductService:IProductService
    {
        private readonly IProductReopsitory _productReopsitory;
        private readonly IProductImagesReopsitory _productImagesReopsitory;
        public ProductService(IProductReopsitory productReopsitory, IProductImagesReopsitory productImagesReopsitory)
        {
            _productReopsitory = productReopsitory;
            _productImagesReopsitory = productImagesReopsitory;


        }
        public async Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
          List<ProductViewModel> result = new List<ProductViewModel>();

            var products = await _productReopsitory.ListAll();
            
            foreach (var product in products)
            {
                var productImages = await _productImagesReopsitory.ListByProductId(product.ProductId);
                result.Add(new ProductViewModel()
                {
                    Title = product.Title,
                    MainImageUrl = product.ImageUrl,
                    SlideShowImages = productImages.Select(p=>p.ImageUrl).ToList(),
                    ProductId = product.ProductId,
                    Description = product.Description,
                    Price = product.Price
                });
            }

            return result;
        }

        public Task AddProduct(ProductViewModel item)
        {
            throw new NotImplementedException();
        }
    }
}
