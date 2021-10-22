using Microsoft.EntityFrameworkCore;

namespace WikiAPI.Models{
    public class WikiSalesDbContext : DbContext {
        public WikiSalesDbContext (DbContextOptions<WikiSalesDbContext> data)
        :base (data){}

        public DbSet<Rol> Rol {get; set;}
        public DbSet<PersonType> PersonType { get; set; }
    }
}