using Dapr.EventBus.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dapr.EventBus.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EventBusController : AbpControllerBase
{
    protected EventBusController()
    {
        LocalizationResource = typeof(EventBusResource);
    }
}
