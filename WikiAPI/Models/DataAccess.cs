using Microsoft.EntityFrameworkCore;

namespace WikiAPI.Models{
    public class WikiSalesDbContext : DbContext {
        public WikiSalesDbContext (DbContextOptions<WikiSalesDbContext> data)
        :base (data){}

        public DbSet<Rol> Rol {get; set;}
        public DbSet<PersonType> PersonType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public DbSet<MethodPayment> MethodPayment { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<UserRol> UserRol { get; set; }
    }
}