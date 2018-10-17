using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness.Services;
using eShopApi.Models;
using eShopApi.Repository.Services;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness
{
    public class PurshaseService:IPurshaseService
    {

        private readonly IPurshaseReopsitory _purshaseReopsitory;
     
        public PurshaseService(IPurshaseReopsitory purshaseReopsitory)
        {
            _purshaseReopsitory = purshaseReopsitory;
        }
        public async Task<IEnumerable<PurshaseViewModel>> GetAllPurshases()
        {
            List<PurshaseViewModel> purshases = new List<PurshaseViewModel>();
            var result = await _purshaseReopsitory.ListAll();

            foreach (var purshase in result)
            {
                purshases.Add(new PurshaseViewModel()
                {
                    PurshaseId = purshase.PurshaseId,CreatedOn = purshase.CreatedOn,ProductId = purshase.ProductId,Quantity = purshase.Quantity,
                    UserId = purshase.UserId
                });
            }
            return purshases;


        }

        public async Task SubmitPurshase(List<PurshaseViewModel> request)
        {
            foreach (var item in request)
            {
                await _purshaseReopsitory.Add(new Purshases()
                {
                    PurshaseId = item.PurshaseId,
                    ProductId = item.ProductId,
                    CreatedOn = item.CreatedOn,
                    Quantity = item.Quantity,
                    UserId = item.UserId
                });
            }
        }

    }
}
