using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DRT.Persistence.MSSQL
{
    public class MsSqlContextFactory : IDesignTimeDbContextFactory<MsSqlFnzDbContext>
    {
        public MsSqlFnzDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.local.json", true)
                .Build();

            var builder = new DbContextOptionsBuilder<MsSqlFnzDbContext>();
            builder.UseSqlServer(
                config.GetConnectionString("FnzDbContext"),
                b => b.MigrationsAssembly("DRT.Persistence.MSSQL")
            );
            return new MsSqlFnzDbContext(builder.Options);
        }
    }
}