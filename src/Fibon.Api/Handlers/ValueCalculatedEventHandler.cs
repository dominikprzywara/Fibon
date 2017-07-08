using Fibon.Api.Repository;
using Fibon.Messages.Events;
using RawRabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Api.Handlers
{
    public class ValueCalculatedEventHandler : IEventHandler<ValueCalculatedEvent>
    {
        private readonly IRepository _repository;

        public ValueCalculatedEventHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(ValueCalculatedEvent @event)
        {
            _repository.Insert(@event.Number, @event.Value);
            await Task.CompletedTask;
        }
    }
}
