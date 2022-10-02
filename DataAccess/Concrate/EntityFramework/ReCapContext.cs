using Core.Entities.Concrate;
using Entities.Concrete;
using Etities.Concrate;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess.Concrate.EntityFramework;

public class ReCapContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Color> Colours { get; set; }
    public DbSet<Brand> Brands { get; set; }

    public DbSet<Costomer> Costomers { get; set; }

    public DbSet<Motorcycle> Motorcycles { get; set; }
    public DbSet<Carimg> CarImages { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReCapProject;Trusted_Connection=true");
    }
}