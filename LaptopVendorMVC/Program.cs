using LaptopVendorMVC.Data;
using LaptopVendorMVC.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.Http.Headers;

namespace LaptopVendorMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using LaptopVendorContext context = new LaptopVendorContext();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            #region CreateAndApplyBrands
            // 1. Dell
            Brand dell = new Brand()
            {
                Name = "Dell"
            };
            context.Brands.Add(dell);

            // 2. HP
            Brand hp = new Brand()
            {
                Name = "HP"
            };
            context.Brands.Add(hp);

            // 3. Lenovo
            Brand lenovo = new Brand()
            {
                Name = "Lenovo"
            };
            context.Brands.Add(lenovo);

            // 4. Asus
            Brand asus = new Brand()
            {
                Name = "Asus"
            };
            context.Brands.Add(asus);

            // 5. Acer
            Brand acer = new Brand()
            {
                Name = "Acer"
            };
            context.Brands.Add(acer);
            #endregion
            #region CreateAndApplyLaptops
            // Create 5 laptops for each brand
            // Dell laptops
            Laptop dell1 = new Laptop()
            {
                Model = "Latitude 5490",
                Brand = dell,
                Price = 1299.99,
                Year = 2018
            };
            context.Laptops.Add(dell1);
            Laptop dell2 = new Laptop()
            {
                Model = "XPS 15",
                Brand = dell,
                Price = 1799.99,
                Year = 2020
            };
            context.Laptops.Add(dell2);
            Laptop dell3 = new Laptop()
            {
                Model = "Inspiron 15 3000",
                Brand = dell,
                Price = 499.99,
                Year = 2021
            };
            context.Laptops.Add(dell3);
            Laptop dell4 = new Laptop()
            {
                Model = "Precision 3551",
                Brand = dell,
                Price = 2199.99,
                Year = 2020
            };
            context.Laptops.Add(dell4);
            Laptop dell5 = new Laptop()
            {
                Model = "Alienware m15 R5",
                Brand = dell,
                Price = 2899.99,
                Year = 2021
            };
            context.Laptops.Add(dell5);


            // HP laptops
            Laptop hp1 = new Laptop()
            {
                Model = "Spectre x360",
                Brand = hp,
                Price = 1399.99,
                Year = 2021
            };
            context.Laptops.Add(hp1);
            Laptop hp2 = new Laptop()
            {
                Model = "ENVY 13",
                Brand = hp,
                Price = 949.99,
                Year = 2020
            };
            context.Laptops.Add(hp2);
            Laptop hp3 = new Laptop()
            {
                Model = "Pavilion Gaming 15",
                Brand = hp,
                Price = 799.99,
                Year = 2021
            };
            context.Laptops.Add(hp3);
            Laptop hp4 = new Laptop()
            {
                Model = "EliteBook 840 G8",
                Brand = hp,
                Price = 1499.99,
                Year = 2021
            };
            context.Laptops.Add(hp4);
            Laptop hp5 = new Laptop()
            {
                Model = "ZBook Fury 15 G8",
                Brand = hp,
                Price = 3299.99,
                Year = 2021
            };
            context.Laptops.Add(hp5);


            // Lenovo laptops
            Laptop lenovo1 = new Laptop()
            {
                Model = "ThinkPad X1 Carbon Gen 9",
                Brand = lenovo,
                Price = 1799.99,
                Year = 2021
            };
            context.Laptops.Add(lenovo1);
            Laptop lenovo2 = new Laptop()
            {
                Model = "IdeaPad 3 15",
                Brand = lenovo,
                Price = 449.99,
                Year = 2021
            };
            context.Laptops.Add(lenovo2);
            Laptop lenovo3 = new Laptop()
            {
                Model = "ThinkBook 14s Gen 2",
                Brand = lenovo,
                Price = 1099.99,
                Year = 2021
            };
            context.Laptops.Add(lenovo3);
            Laptop lenovo4 = new Laptop()
            {
                Model = "Yoga Slim 7 Carbon",
                Brand = lenovo,
                Price = 1499.99,
                Year = 2021
            };
            context.Laptops.Add(lenovo4);
            Laptop lenovo5 = new Laptop()
            {
                Model = "Legion 5 Pro",
                Brand = lenovo,
                Price = 1399.99,
                Year = 2021
            };
            context.Laptops.Add(lenovo5);

            // Asus laptops
            Laptop asus1 = new Laptop()
            {
                Model = "ROG Zephyrus G15",
                Brand = asus,
                Price = 1499.99,
                Year = 2021
            };
            context.Laptops.Add(asus1);
            Laptop asus2 = new Laptop()
            {
                Model = "ZenBook 13",
                Brand = asus,
                Price = 899.99,
                Year = 2021
            };
            context.Laptops.Add(asus2);
            Laptop asus3 = new Laptop()
            {
                Model = "TUF Dash F15",
                Brand = asus,
                Price = 1099.99,
                Year = 2021
            };
            context.Laptops.Add(asus3);
            Laptop asus4 = new Laptop()
            {
                Model = "VivoBook S15",
                Brand = asus,
                Price = 699.99,
                Year = 2021
            };
            context.Laptops.Add(asus4);
            Laptop asus5 = new Laptop()
            {
                Model = "ProArt StudioBook Pro X",
                Brand = asus,
                Price = 5499.99,
                Year = 2021
            };
            context.Laptops.Add(asus5);


            // Acer laptops
            Laptop acer1 = new Laptop()
            {
                Model = "Predator Triton 500",
                Brand = acer,
                Price = 1799.99,
                Year = 2021
            };
            context.Laptops.Add(acer1);
            Laptop acer2 = new Laptop()
            {
                Model = "Swift 3",
                Brand = acer,
                Price = 699.99,
                Year = 2021
            };
            context.Laptops.Add(acer2);
            Laptop acer3 = new Laptop()
            {
                Model = "Aspire 5",
                Brand = acer,
                Price = 599.99,
                Year = 2021
            };
            context.Laptops.Add(acer3);
            Laptop acer4 = new Laptop()
            {
                Model = "Spin 5",
                Brand = acer,
                Price = 849.99,
                Year = 2021
            };
            context.Laptops.Add(acer4);
            Laptop acer5 = new Laptop()
            {
                Model = "ConceptD 7 Ezel",
                Brand = acer,
                Price = 2799.99,
                Year = 2021
            };
            context.Laptops.Add(acer5);
            #endregion
            // Save changes to database
            context.SaveChanges();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}