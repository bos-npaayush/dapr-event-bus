using Volo.Abp.Settings;

namespace Dapr.EventBus.Settings;

public class EventBusSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EventBusSettings.MySetting1));
    }
}
