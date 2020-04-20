using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DRT.Persistence.MySQL
{
    public class MySqlContextFactory : IDesignTimeDbContextFactory<MySqlFnzDbContext>
    {
        public MySqlFnzDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile("appsettings.local.json", true)
                .Build();

            var builder = new DbContextOptionsBuilder<FnzDbContext>();
            builder.UseMySql(
                config.GetConnectionString("FnzDbContext"),
                b => b.MigrationsAssembly("DRT.Persistence.MySQL")
            );

            return new MySqlFnzDbContext(builder.Options);
        }
    }
}