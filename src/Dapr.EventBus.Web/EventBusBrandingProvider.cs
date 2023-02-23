using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dapr.EventBus.Web;

[Dependency(ReplaceServices = true)]
public class EventBusBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EventBus";
}
