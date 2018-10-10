using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eShopApi.ViewModels
{
    public class ProductViewModel
    {
        public Guid ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string MainImageUrl { get; set; }
        public List<string> SlideShowImages { get; set; }
    }
}