using System.Data.Entity;



namespace CampingWorldNew.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("CampingWorldNew")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}