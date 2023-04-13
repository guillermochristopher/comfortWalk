/*This Class (named context class) is used to manage and access the data from 
 * entity classes (Product and Category)
 */
using comfortWalk.Models;
using System.Data.Entity;
namespace comfortWalk.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("comfortWalk")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}