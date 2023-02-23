using Dapr.EventBus.ETOs;
using Dapr.EventBus.Events;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace Dapr.EventBus.EventHandlers
{
    public class DaprEventBusEventHandler : IDistributedEventHandler<StockCountChangedEto>, ITransientDependency
    {
        private readonly ILogger<DaprEventBusEventHandler> _logger;
        public DaprEventBusEventHandler(ILogger<DaprEventBusEventHandler> logger)
        {
            _logger = logger;
        }
        public Task HandleEventAsync(StockCountChangedEto eventData)
        {
            this._logger.LogInformation($"::DaprEventBusEventHandler:: -- HandleEventAsync -- Product: {eventData.Product}. Date: {eventData.ChangedDate}");
            return Task.CompletedTask;
        }
    }
}
