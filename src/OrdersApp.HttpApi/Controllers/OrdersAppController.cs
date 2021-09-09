using OrdersApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OrdersApp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class OrdersAppController : AbpController
    {
        protected OrdersAppController()
        {
            LocalizationResource = typeof(OrdersAppResource);
        }
    }
}