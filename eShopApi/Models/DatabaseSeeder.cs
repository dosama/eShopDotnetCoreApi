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
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Products()
                    {
                        ProductId = new Guid("78e281c9-bbbf-4eb4-aef5-391c38c559a3"),
                        Title = "LG Smart TV 40",
                        Price = 50.00M,
                        ImageUrl = "https://image.ibb.co/ghrfPU/Product-Image-png.jpg",
                        Description =
                            "A smart TV device is either a television set with integrated Internet capabilities or a set-top box for television that offers more advanced computing ability and connectivity than a contemporary basic television set. Smart TVs may be thought of as an information appliance or the computer system from a handheld computer integrated within a television set unit as such a smart TV often allows the user to install and run more advanced applications or plugins/addons based on a specific platform. Smart TVs run a complete operating system or mobile operating system software providing a platform for application developers"
                    },
                    new Products()
                    {
                        ProductId = new Guid("5a82b800-f828-4c42-ac89-970b04c7fd9c"),
                        Title = "LG Smart TV 50",
                        Price = 70.00M,
                        ImageUrl = "https://image.ibb.co/ghrfPU/Product-Image-png.jpg",
                        Description =
                            "A smart TV device is either a television set with integrated Internet capabilities or a set-top box for television that offers more advanced computing ability and connectivity than a contemporary basic television set. Smart TVs may be thought of as an information appliance or the computer system from a handheld computer integrated within a television set unit as such a smart TV often allows the user to install and run more advanced applications or plugins/addons based on a specific platform. Smart TVs run a complete operating system or mobile operating system software providing a platform for application developers"
                    },
                    new Products()
                    {
                        ProductId = new Guid("54c66ecf-966d-41da-ad61-3772cf44b6b1"),
                        Title = "LG Smart TV 60",
                        Price = 90.00M,
                        ImageUrl = "https://image.ibb.co/ghrfPU/Product-Image-png.jpg",
                        Description =
                            "A smart TV device is either a television set with integrated Internet capabilities or a set-top box for television that offers more advanced computing ability and connectivity than a contemporary basic television set. Smart TVs may be thought of as an information appliance or the computer system from a handheld computer integrated within a television set unit as such a smart TV often allows the user to install and run more advanced applications or plugins/addons based on a specific platform. Smart TVs run a complete operating system or mobile operating system software providing a platform for application developers"
                    },
                    new Products()
                    {
                        ProductId = new Guid("3c963666-a0d8-4646-af7c-d2678efd6671"),
                        Title = "LG Smart TV 70",
                        Price = 200.00M,
                        ImageUrl = "https://image.ibb.co/ghrfPU/Product-Image-png.jpg",
                        Description =
                            "A smart TV device is either a television set with integrated Internet capabilities or a set-top box for television that offers more advanced computing ability and connectivity than a contemporary basic television set. Smart TVs may be thought of as an information appliance or the computer system from a handheld computer integrated within a television set unit as such a smart TV often allows the user to install and run more advanced applications or plugins/addons based on a specific platform. Smart TVs run a complete operating system or mobile operating system software providing a platform for application developers"
                    }
                );

            }
            if (!context.ProductsImages.Any())
            {

                context.ProductsImages.AddRange(
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("78e281c9-bbbf-4eb4-aef5-391c38c559a3"),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/718qyrcH1yL._SL1500_.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("78e281c9-bbbf-4eb4-aef5-391c38c559a3"),
                        ImageUrl = "https://5.imimg.com/data5/NE/YG/MY-8945380/smart-led-tv-500x500.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("78e281c9-bbbf-4eb4-aef5-391c38c559a3"),
                        ImageUrl =
                            "https://rukminim1.flixcart.com/image/832/832/television/n/t/w/lg-49lh576t-original-imaejnzcy9qhtrng.jpeg?q=70"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("78e281c9-bbbf-4eb4-aef5-391c38c559a3"),
                        ImageUrl =
                            "https://ksassets.timeincuk.net/wp/uploads/sites/54/2013/06/LG55LA740VFrontDone-6-620x412.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("78e281c9-bbbf-4eb4-aef5-391c38c559a3"),
                        ImageUrl =
                            "https://cf2.s3.souqcdn.com/item/2017/02/14/10/88/56/87/item_XL_10885687_28629081.jpg"
                    },


                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("5a82b800-f828-4c42-ac89-970b04c7fd9c"),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/718qyrcH1yL._SL1500_.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("5a82b800-f828-4c42-ac89-970b04c7fd9c"),
                        ImageUrl = "https://5.imimg.com/data5/NE/YG/MY-8945380/smart-led-tv-500x500.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("5a82b800-f828-4c42-ac89-970b04c7fd9c"),
                        ImageUrl =
                            "https://rukminim1.flixcart.com/image/832/832/television/n/t/w/lg-49lh576t-original-imaejnzcy9qhtrng.jpeg?q=70"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("5a82b800-f828-4c42-ac89-970b04c7fd9c"),
                        ImageUrl =
                            "https://ksassets.timeincuk.net/wp/uploads/sites/54/2013/06/LG55LA740VFrontDone-6-620x412.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("5a82b800-f828-4c42-ac89-970b04c7fd9c"),
                        ImageUrl =
                            "https://cf2.s3.souqcdn.com/item/2017/02/14/10/88/56/87/item_XL_10885687_28629081.jpg"
                    },


                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("54c66ecf-966d-41da-ad61-3772cf44b6b1"),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/718qyrcH1yL._SL1500_.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("54c66ecf-966d-41da-ad61-3772cf44b6b1"),
                        ImageUrl = "https://5.imimg.com/data5/NE/YG/MY-8945380/smart-led-tv-500x500.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("54c66ecf-966d-41da-ad61-3772cf44b6b1"),
                        ImageUrl =
                            "https://rukminim1.flixcart.com/image/832/832/television/n/t/w/lg-49lh576t-original-imaejnzcy9qhtrng.jpeg?q=70"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("54c66ecf-966d-41da-ad61-3772cf44b6b1"),
                        ImageUrl =
                            "https://ksassets.timeincuk.net/wp/uploads/sites/54/2013/06/LG55LA740VFrontDone-6-620x412.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("54c66ecf-966d-41da-ad61-3772cf44b6b1"),
                        ImageUrl =
                            "https://cf2.s3.souqcdn.com/item/2017/02/14/10/88/56/87/item_XL_10885687_28629081.jpg"
                    },

                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("3c963666-a0d8-4646-af7c-d2678efd6671"),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/718qyrcH1yL._SL1500_.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("3c963666-a0d8-4646-af7c-d2678efd6671"),
                        ImageUrl = "https://5.imimg.com/data5/NE/YG/MY-8945380/smart-led-tv-500x500.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("3c963666-a0d8-4646-af7c-d2678efd6671"),
                        ImageUrl =
                            "https://rukminim1.flixcart.com/image/832/832/television/n/t/w/lg-49lh576t-original-imaejnzcy9qhtrng.jpeg?q=70"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("3c963666-a0d8-4646-af7c-d2678efd6671"),
                        ImageUrl =
                            "https://ksassets.timeincuk.net/wp/uploads/sites/54/2013/06/LG55LA740VFrontDone-6-620x412.jpg"
                    },
                    new ProductsImages()
                    {
                        Id = Guid.NewGuid(),
                        ProductId = new Guid("3c963666-a0d8-4646-af7c-d2678efd6671"),
                        ImageUrl =
                            "https://cf2.s3.souqcdn.com/item/2017/02/14/10/88/56/87/item_XL_10885687_28629081.jpg"
                    }
                );
            }
            try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                   
                }
               
            }
    }
}