using CoureTest_API.Data;
using Microsoft.EntityFrameworkCore;

namespace CoureTest_API.Models
{
    public static class SeedDatabaseDefaultData
    {
        public static void SeedDatabase(this IServiceCollection services)
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "Database").Options;
            var db = new DataContext(options);
            SeedData.Seed(db);
        }
    }
}
