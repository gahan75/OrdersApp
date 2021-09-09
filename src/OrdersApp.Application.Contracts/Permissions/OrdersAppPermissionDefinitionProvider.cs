using OrdersApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OrdersApp.Permissions
{
    public class OrdersAppPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OrdersAppPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(OrdersAppPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OrdersAppResource>(name);
        }
    }
}
