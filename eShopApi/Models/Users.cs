using System;
using System.ComponentModel.DataAnnotations;

namespace eShopApi.Models
{
    public class Users
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
    }
}