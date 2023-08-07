using Microsoft.EntityFrameworkCore;
using Superheroes001.Entities;

namespace Superheroes001.EF;

public class DatabaseContext : DbContext
{
    // this can be used in several ways
    // 1) connection directly from here
    // 2) connection in configuration file
    public DatabaseContext(DbContextOptions<DatabaseContext> option)
        :base(option)
    {
        // I think we can make the con_string here if wanted...
    }

    // tables in DB
    public DbSet<Hero> Hero { get; set; }

}
