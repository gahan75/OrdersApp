using System;
using System.Collections.Generic;
using System.Text;
using OrdersApp.Localization;
using Volo.Abp.Application.Services;

namespace OrdersApp
{
    /* Inherit your application services from this class.
     */
    public abstract class OrdersAppAppService : ApplicationService
    {
        protected OrdersAppAppService()
        {
            LocalizationResource = typeof(OrdersAppResource);
        }
    }
}
