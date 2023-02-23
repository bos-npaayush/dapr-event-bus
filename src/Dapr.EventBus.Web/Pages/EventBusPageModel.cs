using Dapr.EventBus.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dapr.EventBus.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class EventBusPageModel : AbpPageModel
{
    protected EventBusPageModel()
    {
        LocalizationResourceType = typeof(EventBusResource);
    }
}
