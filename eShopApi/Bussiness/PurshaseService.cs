using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness.Services;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness
{
    public class PurshaseService:IPurshaseService
    {
        public Task<IEnumerable<PurshaseViewModel>> GetAllPurshases()
        {
            throw new NotImplementedException();
        }

        public Task SubmitPurshase(PurshaseViewModel item)
        {
            throw new NotImplementedException();
        }
    }
}
