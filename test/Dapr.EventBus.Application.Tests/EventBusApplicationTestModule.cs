using Volo.Abp.Modularity;

namespace Dapr.EventBus;

[DependsOn(
    typeof(EventBusApplicationModule),
    typeof(EventBusDomainTestModule)
    )]
public class EventBusApplicationTestModule : AbpModule
{

}
