using OrdersApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OrdersApp.Blazor
{
    public abstract class OrdersAppComponentBase : AbpComponentBase
    {
        protected OrdersAppComponentBase()
        {
            LocalizationResource = typeof(OrdersAppResource);
        }
    }
}
