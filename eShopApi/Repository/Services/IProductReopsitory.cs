using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;

namespace eShopApi.Repository.Services
{
    public interface IProductReopsitory
    {
        Task<IEnumerable<Products>> ListAll();
        Task Add(Products item);
    }
}
