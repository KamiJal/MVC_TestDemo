using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNet.Identity.EntityFramework;
using TestDemo.Models;
using TestDemo.Utils;

namespace TestDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestDemo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Roles.AddOrUpdate(r => r.Id,
                new IdentityRole(AppStrings.AppRoleNames.Admin),
                new IdentityRole(AppStrings.AppRoleNames.Manager),
                new IdentityRole(AppStrings.AppRoleNames.Customer));

            context.Manufacturers.AddOrUpdate(m => m.Id,
                new Manufacturer() {Id = 1, Name = "LG"},
                new Manufacturer() {Id = 2, Name = "Samsung"},
                new Manufacturer() {Id = 3, Name = "Sony"});

            context.Products.AddOrUpdate(p => p.Id,
                new Product()
                    {Id = 1, ManufacturerId = 1, Name = "32LH590U", Price = 89990, ProductCode = 69323},
                new Product()
                    {Id = 2, ManufacturerId = 1, Name = "55UJ651V", Price = 299990, ProductCode = 72612},
                new Product()
                    {Id = 3, ManufacturerId = 1, Name = "55C8PLA", Price = 799990, ProductCode = 79805},
                new Product()
                    {Id = 4, ManufacturerId = 2, Name = "UE43M5500AUXCE", Price = 164990, ProductCode = 73057},
                new Product()
                    {Id = 5, ManufacturerId = 2, Name = "UE49MU6500UXCE", Price = 242990, ProductCode = 73062},
                new Product()
                    {Id = 6, ManufacturerId = 2, Name = "UE55KU6000UXCE", Price = 279990, ProductCode = 68387},
                new Product()
                    {Id = 7, ManufacturerId = 3, Name = "KDL32WD603", Price = 129990, ProductCode = 67880},
                new Product()
                    {Id = 8, ManufacturerId = 3, Name = "KDL40WD653", Price = 149990, ProductCode = 68685},
                new Product()
                    {Id = 9, ManufacturerId = 3, Name = "KDL48WD653BR", Price = 209990, ProductCode = 67882});
        }
    }
}