using Microsoft.Extensions.DependencyInjection;
using RabbitmqMicroservice.Transfer.Application.Interfaces;
using RabbitmqMicroservice.Transfer.Application.Services;
using RabbitmqMicroservices.Banking.Application.Services;
using RabbitmqMicroservices.Banking.Data.Context;
using RabbitmqMicroservices.Banking.Data.Reppository;
using RabbitmqMicroservices.Banking.Domain.Interfaces;
using RabbitmqMicroservices.Domain.Core.Bus;
using RabbitmqMicroservices.Infra.Bus;
using RabbitmqMicroservices.Transfer.Data.Context;
using RabbitmqMicroservices.Transfer.Data.Repository;
using RabbitmqMicroservices.Transfer.Domain.EventHandlers;
using RabbitmqMicroservices.Transfer.Domain.Events;
using RabbitmqMicroservices.Transfer.Domain.Interfaces;
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

            // Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            // application services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferLogService, TransferLogService>();

            // data 
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();

            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
