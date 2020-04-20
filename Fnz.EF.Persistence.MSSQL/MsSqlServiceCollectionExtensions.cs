using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DRT.Persistence.MSSQL
{
    public static class MsSqlServiceCollectionExtensions
    {
        public static IServiceCollection AddMssqlDbContext(
            this IServiceCollection serviceCollection,
            IConfiguration config = null)
        {
            serviceCollection.AddDbContext<FnzDbContext, MsSqlFnzDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("FnzDbContext"), b => b.MigrationsAssembly("DRT.Persistence.MSSQL"));
            });
            return serviceCollection;
        }
    }
}