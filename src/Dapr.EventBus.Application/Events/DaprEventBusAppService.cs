using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp;
using Dapr.EventBus.ETOs;
using Microsoft.Extensions.Logging;

namespace Dapr.EventBus.Events
{
    public class DaprEventBusAppService : EventBusAppService
    {
        private readonly IDistributedEventBus _distributedEventBus;
        private readonly ILogger<DaprEventBusAppService> _logger;
        public DaprEventBusAppService(
            IDistributedEventBus distributedEventBus, ILogger<DaprEventBusAppService> logger)
        {
            _distributedEventBus = distributedEventBus;
            _logger = logger;
        }
        public async Task<IActionResult> PublishAsync()
        {
            try
            {
                this._logger.LogInformation("::DaprEventBusAppService:: -- PublishAsync");
                for (var i = 0; i < 1; i++)
                {
                    await _distributedEventBus.PublishAsync(
                        new StockCountChangedEto
                        (
                            Product: $"Product {i}",
                            ChangedDate: DateTime.Now
                        )
                    );

                    await Task.Delay(500);
                }
                return new OkResult();
            }

            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message);
            }

        }
    }
}
