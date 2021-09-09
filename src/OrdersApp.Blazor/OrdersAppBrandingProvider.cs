using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OrdersApp.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class OrdersAppBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "OrdersApp";
    }
}
