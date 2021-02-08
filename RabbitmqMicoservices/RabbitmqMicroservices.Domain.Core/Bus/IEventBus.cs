using RabbitmqMicroservices.Domain.Core.Commands;
using RabbitmqMicroservices.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RabbitmqMicroservices.Domain.Core.Bus
{
    interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;



    }
}
