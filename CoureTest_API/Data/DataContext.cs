using CoureTest_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoureTest_API.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetails> CountryDetails { get; set; }
    }

}
