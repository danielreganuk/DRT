using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DRT.Persistence.MSSQL
{
    public class MsSqlContextFactory : IDesignTimeDbContextFactory<MsSqlDRTDbContext>
    {
        public MsSqlDRTDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.local.json", true)
                .Build();

            var builder = new DbContextOptionsBuilder<MsSqlDRTDbContext>();
            builder.UseSqlServer(
                config.GetConnectionString("DRTDbContext"),
                b => b.MigrationsAssembly("DRT.Persistence.MSSQL")
            );
            return new MsSqlDRTDbContext(builder.Options);
        }
    }
}