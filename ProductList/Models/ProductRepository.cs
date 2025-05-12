using System.Collections.Generic;

namespace ProductList.Models
    {
    public class ProductRepository
        {

        public static List<Supplier> GetSuppliers()
        {
            return new List<Supplier>()
            {
                new Supplier {Id = 1, Name ="Liam Mokoena"},
                new Supplier {Id = 2, Name ="Ayanda Patel"},
                new Supplier {Id = 3, Name ="Naledi Technologies"},


            };
        }
        public static List<Category> GetCategories()
            {
            return new List<Category>
    {
        new Category { Id = 1, Name = "Electronics", SupplierId = 1 },
        new Category { Id = 2, Name = "Home Appliances", SupplierId = 1 },
        new Category { Id = 3, Name = "Stationery", SupplierId = 2 },
        new Category { Id = 4, Name = "Office Furniture", SupplierId = 2 },
        new Category { Id = 5, Name = "Outdoor Gear" , SupplierId = 3},
        new Category {Id = 6, Name = "Sports Equipment", SupplierId = 3},
        new Category {Id = 7, Name = "Kitchenware", SupplierId = 1},
        new Category {Id = 8, Name = "Books", SupplierId = 2},
        new Category {Id = 9, Name = "Gaming Accessories", SupplierId = 3}
    };
            }

        public static List<Product> GetProducts()
            {
            return new List<Product>
    {
        new Product { Id = 1, Name = "Bluetooth Speaker", CategoryId = 1 },
        new Product { Id = 2, Name = "Smartwatch", CategoryId = 1 },
        new Product { Id = 3, Name = "Microwave Oven", CategoryId = 2 },
        new Product { Id = 4, Name = "Electric Kettle", CategoryId = 3 },
        new Product { Id = 5, Name = "Ballpoint Pens", CategoryId = 3 },
        new Product { Id = 6, Name = "Notepad Set", CategoryId = 4 },
        new Product { Id = 7, Name = "Office Chair", CategoryId = 4 },
        new Product { Id = 8, Name = "Standing Desk", CategoryId = 4 },
        new Product { Id = 9, Name = "Camping Tent", CategoryId = 5 },
        new Product { Id = 10, Name = "Hiking Backpack", CategoryId = 5 },
        new Product { Id = 11, Name = "Yoga Mat", CategoryId = 6 },
        new Product {Id = 12, Name = "Dumbbell Set", CategoryId = 6},
        new Product {Id = 13, Name = "Cutlery Set", CategoryId = 7},
        new Product {Id = 14, Name = "Non-stick Frying Pan", CategoryId = 7},
        new Product {Id = 15, Name = "Science Textbook", CategoryId = 8},
        new Product {Id = 16, Name = "Wireless Gaming Mouse", CategoryId = 9}
        

    };
            }
        }
    }