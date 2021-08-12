using Avaliacao.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Avaliacao.API.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<StatusHealth>()
            .HasOne<StudentAddress>(s => s.Address)
            .WithOne(ad => ad.Student)
            .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);
            */
        }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<PetOwner> PetOwners { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Accommodation> Accommodation { get; set; }
        public DbSet<StatusAccommodation> StatusAccommodation { get; set; }
        public DbSet<StatusHealth> StatusHealth { get; set; }


    }
}
