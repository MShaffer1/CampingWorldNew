using System.Collections.Generic;
using System.Data.Entity;

namespace CampingWorldNew.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Tents"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Grills"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Grill Tools"
                },

            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Family Size Tent",
                    Description = "This tent is big enough for a family of 4 featuring a dividing wall and mesh ventilation!",
                    ImagePath="RedTentLg.png",
                    UnitPrice = 79.99,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Two person Tent",
                    Description = "Spacious two-person tent perfect for short getaways!",
                    ImagePath="SmallTent.png",
                    UnitPrice = 39.99,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Child Tent",
                    Description = "Small Colorful Tent Suitable for children!",
                    ImagePath="ChildTent.png",
                    UnitPrice = 22.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Small Grill",
                    Description = "Table top duel grill and burner for a complete meal!",
                    ImagePath="SmallGrill.png",
                    UnitPrice = 28.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Large Grill",
                    Description = "Grill big enough for a Party!",
                    ImagePath="LgGrill.png",
                    UnitPrice = 69.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Classic Standing Grill",
                    Description = "Classic style charcoal grill!",
                    ImagePath="GrillonStand.png",
                    UnitPrice = 32.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Grill Skewers",
                    Description = "Wood Handle Grill Skewers",
                    ImagePath="GrillSkewers.png",
                    UnitPrice = 5.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Grill Tool Set with Case",
                    Description = "Full Grill Tool set comes in a beautiful case!",
                    ImagePath="GrillUtensilSetwithCase.png",
                    UnitPrice = 33.99,
                    CategoryID = 3
            },
            new Product
            {
                ProductID = 9,
                ProductName = "Wood Grill Utensil Set",
                Description = "Wood Handled Spatula (2), skewers(6), and baster brush",
                ImagePath = "WoodGrillUtensilSet.png",
                UnitPrice = 18.99,
                CategoryID = 3
            },
             new Product
            {
                ProductID = 10,
                ProductName = "Heavy Duty Grill Tool Set",
                Description = "Heavy Duty metal set of 4 Grill Tools",
                ImagePath = "HeavyDutyGrillToolSet.png",
                UnitPrice = 22.99,
                CategoryID = 3
            }
         };

            return products;
        }
    }
}