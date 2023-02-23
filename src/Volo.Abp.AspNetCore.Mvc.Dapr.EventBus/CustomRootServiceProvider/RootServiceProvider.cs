using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.Dapr.EventBus.CustomRootServiceProvider
{
    [ExposeServices(typeof(IRootServiceProvider))]
    public class RootServiceProvider : IRootServiceProvider, ISingletonDependency
    {
        protected IServiceProvider ServiceProvider { get; }

        public RootServiceProvider(IObjectAccessor<IServiceProvider> objectAccessor)
        {
            ServiceProvider = objectAccessor.Value;
        }

        public virtual object GetService(Type serviceType)
        {
            return ServiceProvider.GetService(serviceType);
        }
    }
}
