using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DRT.Persistence.MySQL
{
    public static class MySqlServiceCollectionExtensions
    {
        public static IServiceCollection AddMysqlDbContext(
            this IServiceCollection serviceCollection,
            IConfiguration config = null)
        {
            serviceCollection.AddDbContext<FnzDbContext, MySqlFnzDbContext>(options =>
            { 
                options.UseMySql(config.GetConnectionString("FnzDbContext"), b => b.MigrationsAssembly("DRT.Persistence.MySQL"));
            });
            return serviceCollection;
        }
    }
}