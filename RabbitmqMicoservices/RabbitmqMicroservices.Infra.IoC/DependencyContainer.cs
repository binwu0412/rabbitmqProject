using Microsoft.Extensions.DependencyInjection;
using RabbitmqMicroservices.Domain.Core.Bus;
using RabbitmqMicroservices.Infra.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMicroservices.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus
            services.AddTransient<IEventBus, RabbitmqBus>();
        }
    }
}
