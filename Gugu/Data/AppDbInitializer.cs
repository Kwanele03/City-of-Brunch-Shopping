
using Gugu.Data.Static;
using Gugu.Models;
using Microsoft.AspNetCore.Identity;


namespace Gugu.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Item= "Ace",
                            Logo="https://th.bing.com/th/id/OIP.C-nVFWK7qMJzCcLuTY59_gHaHm?pid=ImgDet&rs=1",
                            Category ="Maize meal",
                            Specification = "10 kg",
                            Price= 99,
                        },
                        new Product()
                        {
                            Item= "King Authur Flour ",
                            Logo="https://th.bing.com/th/id/R.4b41fadb43d9dbfd5dff034ba33ae666?rik=VxkWXIEC5qdwFQ&pid=ImgRaw&r=0",
                            Category ="Flour",
                            Specification = "10 kg",
                            Price= 121,
                        },
                        new Product()
                        {
                            Item= "Bull Brand",
                            Logo="https://th.bing.com/th/id/R.73d5420e270793db01373ab6f85b2771?rik=w0MDH9zB5GmThQ&pid=ImgRaw&r=0",
                            Category ="Canned Food",
                            Specification = "300g",
                            Price= 38,
                        },
                        new Product()
                        {
                            Item= "Vegitable Oil",
                            Logo="https://th.bing.com/th/id/OIP.17fSe1aWIPa4YawxoQifZAHaHa?pid=ImgDet&rs=1",
                            Category ="Oil",
                            Specification = "2lt",
                            Price= 87,
                        },
                        new Product()
                        {
                            Item= "Coca Cola",
                            Logo="https://th.bing.com/th/id/OIP.TFloL5PqMIdBMYREKQOEegHaHa?w=218&h=218&c=7&r=0&o=5&pid=1.7",
                            Category ="Soda",
                            Specification = "2lt",
                            Price= 19,
                        },
                        new Product()
                        {
                            Item= "Bananas",
                            Logo="https://th.bing.com/th/id/OIP.iHUuWz6FROXxbz7JB2JkYQHaHa?w=173&h=180&c=7&r=0&o=5&pid=1.7",
                            Category ="Fruits",
                            Specification = "1kg",
                            Price= 22,
                        },
                        new Product()
                        {
                            Item= "Tomato",
                            Logo="https://th.bing.com/th/id/R.3e59c78659edfdf2cf9e021ce24c8e61?rik=DtsKyQNcPK7PcQ&pid=ImgRaw&r=0",
                            Category ="Vegitable",
                            Specification = "1kg",
                            Price= 29,
                        },
                        new Product()
                        {
                            Item= "Spekko",
                            Logo="https://th.bing.com/th/id/OIP.meTYj8WWv-AbB5LB8vkSGwAAAA?pid=ImgDet&w=206&h=206&c=7",
                            Category ="Rice",
                            Specification = "10 kg",
                            Price= 119,
                        },
                        new Product()
                        {
                            Item= "Ace",
                            Logo="https://th.bing.com/th/id/OIP.RLxo1VEtSRbzoWivgjLkyQHaH6?w=182&h=195&c=7&r=0&o=5&pid=1.7",
                            Category ="Samp",
                            Specification = "5 kg",
                            Price= 79,
                        },
                        new Product()
                        {
                            Item= "KOO",
                            Logo="https://www.shoprite.co.za/medias/10413483EA-checkers300Wx300H?context=bWFzdGVyfGltYWdlc3w5MTU2MHxpbWFnZS9wbmd8aW1hZ2VzL2g5NS9oOTgvODk1NTc5MzI0NDE5MC5wbmd8ZGI4ZGRhYzJjMWI2NWZmNDBkMGM0NzAzM2FmNDgxNjU4NTcyMTM2ZmY1ZjgyZmE4NmQ0Y2FmNjI5M2Y1YTEyZQ",
                            Category ="Canned Food",
                            Specification = "500g",
                            Price= 13,
                        },
                        new Product()
                        {
                            Item= "Orange Valley",
                            Logo="https://th.bing.com/th/id/OIP.QnYbF0CD71pU9ZYsDA3ZYQHaHa?w=159&h=180&c=7&r=0&o=5&pid=1.7",
                            Category ="Eggs",
                            Specification = "30's",
                            Price= 79,
                        },
                        new Product()
                        {
                            Item= "Nola Mayonnaise",
                            Logo="https://th.bing.com/th/id/OIP.3Pgsdcd6YXgzfY9HX5euGwHaHa?pid=ImgDet&w=206&h=206&c=7",
                            Category ="Sauce",
                            Specification = "750ml",
                            Price= 29,
                        },
                        new Product()
                        {
                            Item= "Sprite",
                            Logo="https://i5.walmartimages.com/asr/047907eb-3444-4870-86a3-943544502e25_1.99328ff9f9197c2c7e2b2864e7f28e95.jpeg?odnHeight=450&odnWidth=450&odnBg=FFFFFF",
                            Category ="Soda",
                            Specification = "2lt",
                            Price= 21,
                        },
                        new Product()
                        {
                            Item= "Golden Chicken",
                            Logo="https://th.bing.com/th/id/OIP.GV4GXmb1F5Yvfo45W997TwAAAA?pid=ImgDet&rs=1",
                            Category ="Meat",
                            Specification = "5kg",
                            Price= 249,
                        },
                        new Product()
                        {
                            Item= "Sunfoil",
                            Logo="https://th.bing.com/th/id/OIP.cAMwJ409VUReMEctJ2g5AAHaHa?pid=ImgDet&rs=1",
                            Category ="Oil",
                            Specification = "2lt",
                            Price= 78,
                        },
                        new Product()
                        {
                            Item= "Tastic",
                            Logo="https://th.bing.com/th/id/OIP.MOh0yXDZdAHRFPdkFBrYiwHaHa?pid=ImgDet&w=206&h=206&c=7",
                            Category ="Rice",
                            Specification = "10 kg",
                            Price= 129,
                        },
                        new Product()
                        {
                            Item= "Oros",
                            Logo="https://th.bing.com/th/id/OIP.KISxZDIrVPJqibzj5w2VxAHaHa?w=195&h=195&c=7&r=0&o=5&pid=1.7",
                            Category ="Juice",
                            Specification = "2lt",
                            Price= 34,
                        },
                        new Product()
                        {
                            Item= "White Star",
                            Logo="https://th.bing.com/th/id/OIP.C-nVFWK7qMJzCcLuTY59_gHaHm?w=145&h=180&c=7&r=0&o=5&pid=1.7",
                            Category ="Maize meal",
                            Specification = "10 kg",
                            Price= 91,
                        },
                        new Product()
                        {
                            Item= "Cabbage",
                            Logo="https://th.bing.com/th/id/OIP.OaBlGqDdN30ItJ_YnDdSCgHaHU?w=197&h=194&c=7&r=0&o=5&pid=1.7",
                            Category ="Vegitable",
                            Specification = "1kg",
                            Price= 24,
                        },
                        new Product()
                        {
                            Item= "Daily",
                            Logo="https://th.bing.com/th/id/OIP.0oYY8pHsBA9Z_GDo_NQR_QHaHa?w=215&h=215&c=7&r=0&o=5&pid=1.7",
                            Category ="Juice",
                            Specification = "3lt",
                            Price= 48,
                        },
                        new Product()
                        {
                            Item= "Rainbow Chicken",
                            Logo="https://th.bing.com/th/id/OIP.fn0SAKQJ-69QAEgxiReXRQHaIr?w=167&h=196&c=7&r=0&o=5&pid=1.7",
                            Category ="Meat",
                            Specification = "5kg",
                            Price= 179,
                        },
                        new Product()
                        {
                            Item= "Orange",
                            Logo="https://th.bing.com/th/id/OIP.I5LirGvSypojSTry1KyVewHaE7?w=238&h=180&c=7&r=0&o=5&pid=1.7",
                            Category ="Fruits",
                            Specification = "5kg",
                            Price= 99,
                        },
                        new Product()
                        {
                            Item= "Impala",
                            Logo="https://th.bing.com/th/id/OIP.HglzxUyxGM0-spLTz7JBQwAAAA?w=205&h=205&c=7&r=0&o=5&pid=1.7",
                            Category ="Maize meal",
                            Specification = "10 kg",
                            Price= 68,
                        },
                        new Product()
                        {
                            Item= "Lucky Star",
                            Logo="https://th.bing.com/th/id/OIP.uYqSMqwi7MyInsOMruSD6AHaGy?w=207&h=190&c=7&r=0&o=5&pid=1.7",
                            Category ="Canned Food",
                            Specification = "750g",
                            Price= 17,
                        }


                    });

                    context.SaveChanges();
                }
              
                if (!context.Stores.Any())
                {
                    context.Stores.AddRange(new List<Store>()
                    {
                        new Store()
                        {
                            Name = "Shoprite",
                            Logo = "https://i0.wp.com/www.marketingspace.com.ng/wp-content/uploads/2019/09/Shoprite.jpg?fit=4273%2C2401&ssl=1",
                             Address = "192 Boom st, Pietermaritzburg",
                            EmailAdress = "Shoprite@cob.com",
                            ContactsDetails = 0335679976
                        },
                        new Store()
                        {
                            Name = "Checkers",
                            Logo = "https://www.minimag.co.za/wp-content/uploads/2014/07/Checkers-Logo.jpg",
                            Address = " 123 East st,Pietermaritzburg",
                            EmailAdress = "Checkers@cob.com",
                           ContactsDetails = 0335006007
                        },
                        new Store()
                        {
                            Name = "Pick n Pay",
                            Logo = "https://www.eco-logicawards.com/wp-content/uploads/2018/06/Logo-Pick-n-Pay.jpg",
                             Address = "221 Boshoff st, Pietermaritzburg",
                              EmailAdress = "PicknPay@cob.com",
                             ContactsDetails = 0338972345
                        },
                        new Store()
                        {
                            Name = "Spar",
                            Logo = "https://th.bing.com/th/id/OIP.47sJGD3mYc2zUkaqC_YilwHaBY?pid=ImgDet&rs=1",
                            Address = "231 Church st, Pietermaritzburg",
                            EmailAdress = "Spar@cob.com",
                            ContactsDetails = 0335670000
                        }

                    });
                    context.SaveChanges();
                }


            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin1))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin1));
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin2))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin2));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                string adminUserEmail = "admin@cob.com";
                string adminUserEmail1 = "admin1@ukzn.com";
                string adminUserEmail2 = "admin2@shoprite.com"; // Add the third admin's email

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        PhoneNumber = 0782630401,
                        DateofBirth = new DateTime(23 / 2 / 2000),
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                var adminUser1 = await userManager.FindByEmailAsync(adminUserEmail1);
                if (adminUser1 == null)
                {
                    var newAdminUser1 = new ApplicationUser()
                    {
                        FullName = "Admin User 1",
                        UserName = "Mjakhura", // Provide a unique username
                        PhoneNumber = 0782630401,
                        DateofBirth = new DateTime(23 / 2 / 2000),
                        Email = adminUserEmail1,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser1, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser1, UserRoles.Admin1);
                }

                var adminUser2 = await userManager.FindByEmailAsync(adminUserEmail2);
                if (adminUser2 == null)
                {
                    var newAdminUser2 = new ApplicationUser()
                    {
                        FullName = "Admin User 2",
                        UserName = "Mbuso", // Provide a unique username
                        PhoneNumber = 0782630401,
                        DateofBirth = new DateTime(23 / 2 / 2000),
                        Email = adminUserEmail2,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser2, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser2, UserRoles.Admin2);
                }

                string appUserEmail = "user@cob.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        PhoneNumber = 0782630401,
                        DateofBirth = new DateTime(23 / 2 / 2000),
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

            }
        }


    }
}
