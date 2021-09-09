using OrdersApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace OrdersApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(OrdersAppEntityFrameworkCoreModule),
        typeof(OrdersAppApplicationContractsModule)
        )]
    public class OrdersAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
