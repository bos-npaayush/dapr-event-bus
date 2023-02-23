using Dapr.EventBus.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dapr.EventBus.Permissions;

public class EventBusPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EventBusPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EventBusPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EventBusResource>(name);
    }
}
