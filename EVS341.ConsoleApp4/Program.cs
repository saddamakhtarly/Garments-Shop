using EVS341.GarmentsShop;
using EVS341.UsersMgt;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS341.ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            using (GarmentsContext context = new GarmentsContext())
            {
                #region Department Adding into Database
                //context.Departments.Add(new Department { Id = 1, Name = "Sale", ImageUrl = "~/Images/banners/b1.jpg" });
                //context.Departments.Add(new Department { Id = 2, Name = "Purchase", ImageUrl = "~/Images/banners/b2.jpg" });
                //context.Departments.Add(new Department { Id = 3, Name = "Advertise", ImageUrl = "~/Images/banners/b3.jpg" });
                //context.Departments.Add(new Department { Id = 4, Name = "Quality", ImageUrl = "~/Images/banners/b1.jpg" });
                //context.SaveChanges();
                #endregion

                #region Category Adding into Database
                //Category c = new Category();
                //c.Name = "Category-1";
                //c.ImageUrl = "~/Images/products/03A.jpg";
                //c.Department = context.Departments.Find(1);
                //context.Categories.Add(c);

                //context.Categories.Add(new Category { Name = "Category-2", ImageUrl = "~/Images/products/03A.jpg", Department = context.Departments.Find(2) });
                //context.Categories.Add(new Category { Name = "Category-3", ImageUrl = "~/Images/products/03A.jpg", Department = context.Departments.Find(3) });
                //context.Categories.Add(new Category { Name = "Category-4", ImageUrl = "~/Images/products/03A.jpg", Department = context.Departments.Find(4) });
                //context.SaveChanges();
                #endregion

                #region SubCategory Adding into Database
                //SubCategory sc = new SubCategory();
                //sc.Name = "SubCategory-1";
                //sc.ImageUrl = "~/Images/products/03A.jpg";
                //sc.Category = context.Categories.Find(1);
                //context.SubCategories.Add(sc);
                //context.SubCategories.Add(new SubCategory { Name = "SubCategory-1", ImageUrl = "~/Images/products/03A.jpg", Category = context.Categories.Find(2) });
                //context.SubCategories.Add(new SubCategory { Name = "SubCategory-1", ImageUrl = "~/Images/products/03A.jpg", Category = context.Categories.Find(3) });
                //context.SubCategories.Add(new SubCategory { Name = "SubCategory-1", ImageUrl = "~/Images/products/03A.jpg", Category = context.Categories.Find(4) });
                //context.SaveChanges();
                #endregion

                #region Fabrics Colors and Size Adding into Database
                //context.Fabrics.Add(new Fabric { Id = 1, Name = "Fabric-1" });
                //context.Fabrics.Add(new Fabric { Id = 2, Name = "Fabric-2" });
                //context.Fabrics.Add(new Fabric { Id = 3, Name = "Fabric-3" });
                //context.Fabrics.Add(new Fabric { Id = 4, Name = "Fabric-4" });
                //context.SaveChanges();

                //context.Colors.Add(new Color { Id = 1, Name = "Blue" });
                //context.Colors.Add(new Color { Id = 2, Name = "Balck" });
                //context.Colors.Add(new Color { Id = 3, Name = "Green" });
                //context.Colors.Add(new Color { Id = 4, Name = "Red" });
                //context.SaveChanges();

                //context.Sizes.Add(new Size { Id = 1, Name = "LG", Number = 1 });
                //context.Sizes.Add(new Size { Id = 2, Name = "MD", Number = 2 });
                //context.Sizes.Add(new Size { Id = 3, Name = "SM", Number = 3 });
                //context.Sizes.Add(new Size { Id = 4, Name = "XM", Number = 4 });
                //context.SaveChanges();
                #endregion

                #region Product Adding into Database
                //Product p = new Product();
                //p.Name = "Product-1";
                //p.Price = 6000;
                //p.Description = "Description of Product-1";
                //p.LaunchingDate = new DateTime(2018, 11, 1);

                //p.Fabric = new Fabric { Id = 4 };
                //context.Entry(p.Fabric).State = EntityState.Unchanged;

                //p.SubCategory = new SubCategory { Id = 4 };
                //context.Entry(p.SubCategory).State = EntityState.Unchanged;

                //p.ColorsOffered.Add(new Color { Id = 3 });
                //p.ColorsOffered.Add(new Color { Id = 4 });

                //p.SizesOffered.Add(new Size { Id = 1 });
                //p.SizesOffered.Add(new Size { Id = 3 });
                //p.SizesOffered.Add(new Size { Id = 2 });
                //p.SizesOffered.Add(new Size { Id = 4 });

                //foreach (var color in p.ColorsOffered)
                //{
                //    context.Entry(color).State = EntityState.Unchanged;
                //}
                //foreach (var size in p.SizesOffered)
                //{
                //    context.Entry(size).State = EntityState.Unchanged;
                //}
                //context.Products.Add(p);
                //context.SaveChanges();

                #endregion


                #region Roles Adding into Database
                //context.Roles.Add(new Role { Id = 1, Name = "Admin" });
                //context.Roles.Add(new Role { Id = 2, Name = "User" });
                //context.SaveChanges();
                #endregion

                #region User Adding into Database
                //User u = new User();
                //u.Name = "Qasim Salemm";
                //u.LoginId = "qasimsaleem";
                //u.Password = "1234";
                //u.SecurityAnswer = "Security Answer";
                //u.SecurityQuestion = "SecurityQuestion";
                //u.ContactNumber = "03057381316";
                //u.BirthDate = new DateTime(1995, 3, 25);
                //u.Email = "qasimsaleem317@gmail.com";
                //u.ImageUrl = "~/Images/others/ns.jpg";
                //u.IsActive = true;
                //u.Role = context.Roles.Find(2);
                //context.Users.Add(u);
                //context.SaveChanges();
                #endregion


                #region Countries Adding into Database
                //context.Countries.Add(new Country { Id = 1, Name = "Pakistan", Code = 92 });
                //context.Countries.Add(new Country { Id = 2, Name = "India", Code = 91 });
                //context.Countries.Add(new Country { Id = 3, Name = "China", Code = 90 });
                //context.SaveChanges();
                #endregion

                #region Province Adding into Database
                //Province p = new Province();
                //p.Id = 1;
                //p.Name = "Blochistan";
                //p.Country = new Country { Id = 1 };
                //context.Entry(p.Country).State = EntityState.Unchanged;
                //context.Provinces.Add(p);
                //context.SaveChanges();
                #endregion

                #region City Adding into Database
                //City c = new City();
                //c.Id = 1;
                //c.Name = "jung";
                //c.Province = new Province { Id = 1 };
                //context.Entry(c.Province).State = EntityState.Unchanged;
                //context.Cities.Add(c);
                //context.SaveChanges();
                #endregion

                #region Address Adding into Database

                //Address a = new Address();
                //a.Id = context.Users.Find(1).Id;
                //a.StreetAddress = "Street No.3";
                //a.City = context.Cities.Find(1);
                //context.Addresses.Add(a);
                //context.SaveChanges();

                #endregion



                #region Show Data into Console
                //Product product = (from a in context.Products
                //                           .Include(m => m.Fabric)
                //                           .Include(m => m.ColorsOffered)
                //                           .Include(m => m.SizesOffered)
                //                           .Include(m => m.SubCategory)
                //                           .Include(m => m.Images)
                //                           .Include(m => m.SubCategory.Category)
                //                           .Include(m => m.SubCategory.Category.Department)
                //                   where a.Id == 1
                //                   select a).First();
                //foreach (var i in product.SizesOffered)
                //{
                //    Console.WriteLine(i.Name);
                //}
                //Console.WriteLine(
                //    product.Id
                //    + product.Name
                //    + product.Price
                //    + product.Description
                //    );
                //Console.WriteLine($"{product.Name},{product.SubCategory.Category.Department.Name} Category costs you Rs.{product.Price}/-");

                #endregion

            }




            Console.WriteLine("Done");
            Console.ReadKey();


        }
    }
}
