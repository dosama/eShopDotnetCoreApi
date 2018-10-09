using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopApi.Models
{
    public class DatabaseSeeder
    {
        public static void InsertSeedData(EShopContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new Users {UserName = "dina1234", UserId = Guid.NewGuid()}
                );

                context.SaveChanges();
            }
        }
    }
}
