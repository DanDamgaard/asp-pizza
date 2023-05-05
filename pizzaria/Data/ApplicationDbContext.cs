using Microsoft.EntityFrameworkCore;
using pizzaria.Models;

namespace pizzaria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options)
        {
            
        }
    }
}
