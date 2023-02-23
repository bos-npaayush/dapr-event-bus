using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EventBus;

namespace Dapr.EventBus.ETOs
{
    [Serializable]
    [EventName("DaprEventBus.StockCountChanged")]
    public record StockCountChangedEto(
    string Product,
    DateTime ChangedDate
    ) : IntegrationEvent;

    public record IntegrationEvent
    {
        public Guid Id { get; }

        public DateTime CreationTime { get; }

        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationTime = DateTime.UtcNow;
        }
    }
}
