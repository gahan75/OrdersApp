using OrdersApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OrdersApp
{
    [DependsOn(
        typeof(OrdersAppEntityFrameworkCoreTestModule)
        )]
    public class OrdersAppDomainTestModule : AbpModule
    {

    }
}