using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness.Services;
using eShopApi.Repository.Services;
using eShopApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IEnumerable<ProductViewModel>> Get()
        {
            try
            {
                return await _productService.GetAllProducts();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
          
        }

      
        [HttpGet("{id}")]
        public ProductViewModel Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
