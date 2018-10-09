using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopApi.Models
{
    public class Purshases
    {
        [Key]
        public Guid PurshaseId { get; set; }

        [ForeignKey("Products")]
        public Guid ProductId { get; set; }
        public Products Product { get; set; }
        [ForeignKey("Users")]
        public Guid UserId { get; set; }
        public Users User { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}