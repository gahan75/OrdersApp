using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrdersApp.Data;
using Volo.Abp.DependencyInjection;

namespace OrdersApp.EntityFrameworkCore
{
    public class EntityFrameworkCoreOrdersAppDbSchemaMigrator
        : IOrdersAppDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreOrdersAppDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the OrdersAppDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<OrdersAppDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
