using Microsoft.Extensions.DependencyInjection;
using RabbitmqMicroservices.Banking.Application.Services;
using RabbitmqMicroservices.Banking.Data.Context;
using RabbitmqMicroservices.Banking.Data.Reppository;
using RabbitmqMicroservices.Banking.Domain.Interfaces;
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

            // application services
            services.AddTransient<IAccountService, AccountService>();

            // data 
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
