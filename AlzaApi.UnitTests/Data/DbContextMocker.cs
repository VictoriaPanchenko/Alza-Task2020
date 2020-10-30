using AlzaApi.Data;
using Microsoft.EntityFrameworkCore;

namespace AlzaApi.UnitTests.Data
{
    public static class DbContextMocker
    {
        public static AlzaContext GetAlzaDbContext(string dbName)
        {
            // Create options for DbContext instance
            var options = new DbContextOptionsBuilder<AlzaContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            // Create instance of DbContext
            var dbContext = new AlzaContext(options);

            // Add entities in memory
            dbContext.Seed();

            return dbContext;
        }
    }
}
