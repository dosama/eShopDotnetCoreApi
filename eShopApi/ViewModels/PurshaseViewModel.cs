using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopApi.ViewModels
{
    public class PurshaseViewModel
    {
       
        public Guid PurshaseId { get; set; }

        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }
    
        public int Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}