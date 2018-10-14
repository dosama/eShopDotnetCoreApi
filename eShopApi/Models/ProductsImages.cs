using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eShopApi.Models
{
    public class ProductsImages
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Products")]
        public Guid ProductId { get; set; }
        public Products Product { get; set; }
        public string ImageUrl { get; set; }
       

    }
}