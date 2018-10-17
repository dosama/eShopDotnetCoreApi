using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness.Services;
using eShopApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    public class PurshaseController : Controller
    {
        private readonly IPurshaseService _purshaseService;
        public PurshaseController(IPurshaseService purshaseService)
        {
            _purshaseService = purshaseService;
        }

        // POST api/values
        [HttpPost]
        public async Task<bool> Post([FromBody]List<PurshaseViewModel> request)
        {
            try
            {
                await  _purshaseService.SubmitPurshase(request);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

       
    }
}
