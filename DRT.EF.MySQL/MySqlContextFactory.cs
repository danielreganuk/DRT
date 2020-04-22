using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DRT.Persistence.MySQL
{
    public class MySqlContextFactory : IDesignTimeDbContextFactory<MySqlDRTDbContext>
    {
        public MySqlDRTDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.local.json", true)
                .Build();

            var builder = new DbContextOptionsBuilder<DRTDbContext>();
            builder.UseMySql(
                config.GetConnectionString("DRTDbContext"),
                b => b.MigrationsAssembly("DRT.Persistence.MySQL")
            );

            return new MySqlDRTDbContext(builder.Options);
        }
    }
}