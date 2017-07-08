using Fibon.Messages.Commands;
using Fibon.Messages.Events;
using RawRabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Service.Handlers
{
    public class CalculateValueCommandHandler : ICommandHandler<CalculateValueCommand>
    {
        private readonly IBusClient _busClient;

        public CalculateValueCommandHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CalculateValueCommand command)
        {
            int result = Fibon(command.Number);

            await _busClient.PublishAsync(new ValueCalculatedEvent { Number = command.Number, Value = result });
        }

        private int Fibon(int number)
        {
            switch (number)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return Fibon(number - 2) + Fibon(number - 1);
            }
        }
    }
}
