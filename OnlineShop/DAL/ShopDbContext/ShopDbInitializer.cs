using System;
using System.Collections.Generic;
using System.Data.Entity;
using DAL.DataEntities;

namespace DAL.ShopDbContext
{
    internal class ShopDbInitializer : DropCreateDatabaseAlways<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context)
        {
            base.Seed(context);
            List<ProductCategory> categories = new List<ProductCategory>(){
                new ProductCategory() {Caption = "Провода соединительные ПВСнг", Description = new CategoryDescription(){Description = "<h3>Hello</h3> from category 1"}},
                new ProductCategory() {Caption = "Плетёнка экранирующая ПМЛ",  Description = new CategoryDescription(){Description = "<h3>Hello</h3> from category 2"}}

            };

            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Caption = "Кабель ШВВП 3х1,5",
                    Category =  categories[0],
                    ImgPath = "assets/products/1.png"
                },
                new Product()
                {
                    Caption = "Кабель ШВВП 3х2,5",
                    Category =  categories[1],
                    ImgPath = "assets/products/2.png"
                },
                new Product()
                {
                    Caption = "Кабель 1",
                    Category =  categories[0],
                    ImgPath = "assets/products/1.png"
                },
                new Product()
                {
                    Caption = "Кабель 2",
                    Category =  categories[1],
                    ImgPath = "assets/products/2.png"
                }

            };

            List<Stage> stages = new List<Stage>()
            {
                new Stage(){Caption = "Новый"},
                new Stage(){Caption = "Подтвержден"},
                new Stage(){Caption = "Отправлен"},
                new Stage(){Caption = "В пути"},
                new Stage() {Caption = "Оджидает получения в отделении почты"},
            };

            List<Order> orders = new List<Order>()
            {
                new Order()
                {
                    Stage = stages[0],
                    Product = products[0],
                    Amount = 86.633,
                    ProductPrice = 19.929,
                    DateOfCreation = DateTime.Now,
                },
                new Order()
                {
                    Stage = stages[1],
                    Product = products[1],
                    Amount = 35.521,
                    ProductPrice = 38.057,
                    DateOfCreation = DateTime.Now,
                },
                new Order()
                {
                    Stage = stages[2],
                    Product = products[2],
                    Amount = 86.633,
                    ProductPrice = 19.929,
                    DateOfCreation = DateTime.Now,
                },
                new Order()
                {
                    Stage = stages[3],
                    Product = products[3],
                    Amount = 35.521,
                    ProductPrice = 38.057,
                    DateOfCreation = DateTime.Now,
                },
                new Order()
                {
                    Stage = stages[4],
                    Product = products[3],
                    Amount = 35.521,
                    ProductPrice = 38.057,
                    DateOfCreation = DateTime.Now,
                },
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }
    }
}
