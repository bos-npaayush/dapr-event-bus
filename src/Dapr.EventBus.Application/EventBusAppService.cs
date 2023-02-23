using System;
using System.Collections.Generic;
using System.Text;
using Dapr.EventBus.Localization;
using Volo.Abp.Application.Services;

namespace Dapr.EventBus;

/* Inherit your application services from this class.
 */
public abstract class EventBusAppService : ApplicationService
{
    protected EventBusAppService()
    {
        LocalizationResource = typeof(EventBusResource);
    }
}
