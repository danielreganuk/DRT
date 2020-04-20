﻿using DRT.Persistence.MSSQL;
using DRT.Persistence.MySQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api
{
    public static class PersistenceServiceCollectionExtensions
    {
        public static IServiceCollection AddConfiguredDbContext(this IServiceCollection serviceCollection,
            IConfiguration config = null)
        {
            var persistenceConfig = config?.GetSection("Persistence")?.Get<PersistenceConfiguration>();

            if (persistenceConfig?.Provider == "MySQL")
            {
                serviceCollection.AddMysqlDbContext(config);
            }
            if (persistenceConfig?.Provider == "MSSQL")
            {
                serviceCollection.AddMssqlDbContext(config);
            }

            return serviceCollection;
        }
    }

    public class PersistenceConfiguration
    {
        public string Provider { get; set; }
    }
}