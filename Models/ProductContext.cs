/*This Class (named context class) is used to manage and access the data from 
 * entity classes (Product and Category)
 */
using comfortWalk.Models;
using System.Data.Entity;
namespace comfortWalk
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}