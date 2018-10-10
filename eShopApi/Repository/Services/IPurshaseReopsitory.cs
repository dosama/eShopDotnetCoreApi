using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Models;

namespace eShopApi.Repository.Services
{
    public interface IPurshaseReopsitory
    {
        Task<IEnumerable<Purshases>> ListAll();
        Task Add(Purshases item);
    }
}
