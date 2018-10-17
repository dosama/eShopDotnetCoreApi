using System.Collections.Generic;
using System.Threading.Tasks;
using eShopApi.Models;
using eShopApi.ViewModels;

namespace eShopApi.Bussiness.Services
{
    public interface IPurshaseService
    {
        Task<IEnumerable<PurshaseViewModel>> GetAllPurshases();
        Task SubmitPurshase(List<PurshaseViewModel> item);
    }
}
