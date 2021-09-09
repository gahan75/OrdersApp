using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OrdersApp.Data
{
    /* This is used if database provider does't define
     * IOrdersAppDbSchemaMigrator implementation.
     */
    public class NullOrdersAppDbSchemaMigrator : IOrdersAppDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}