using Volo.Abp.Settings;

namespace OrdersApp.Settings
{
    public class OrdersAppSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(OrdersAppSettings.MySetting1));
        }
    }
}
