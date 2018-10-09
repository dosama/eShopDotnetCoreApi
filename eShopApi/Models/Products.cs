using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eShopApi.Models
{
    public class Products
    {
        [Key]
        public Guid ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}