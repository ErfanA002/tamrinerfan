using Microsoft.EntityFrameworkCore;
using tamrinerfan.Core.Domain.Person;
using tamrinerfan.Core.Domain.Person.Person;

namespace tamrinerfan.Infra.Efsql;
public class TamrinErfanDbContext : DbContext
{
    public TamrinErfanDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<City> Citys { get; set; }
}
