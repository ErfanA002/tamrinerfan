using Microsoft.EntityFrameworkCore;
using tamrinerfan.Domain;
namespace tamrinerfan.DataAccess;
public class TamrinErfanDbContext : DbContext
{
    public TamrinErfanDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<City> Citys { get; set; }
}
