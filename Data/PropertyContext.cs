using Microsoft.EntityFrameworkCore;
using RentalApplicationAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;




namespace RentalApplicationAPI.Data{
    
    
    public class PropertyContext : IdentityDbContext<ApplicationUser>{
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder) {
            string connection = "User ID=PropertyUser; Password=password; Host=localhost; Port=5432; Database=Property; Pooling=true;";

            optionsBuilder.UseNpgsql(connection);
        }
        public DbSet<Contract> Contracts {get; set; }
        public DbSet<Sale> Sales {get; set;}
        public DbSet<Rental> Rentals {get; set; }
        
     }
}
