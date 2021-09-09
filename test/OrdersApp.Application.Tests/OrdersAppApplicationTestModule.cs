using Volo.Abp.Modularity;

namespace OrdersApp
{
    [DependsOn(
        typeof(OrdersAppApplicationModule),
        typeof(OrdersAppDomainTestModule)
        )]
    public class OrdersAppApplicationTestModule : AbpModule
    {

    }
}