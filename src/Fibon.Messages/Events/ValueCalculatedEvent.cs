namespace Fibon.Messages.Events
{
    public class ValueCalculatedEvent : IEvent
    {
        public int Number { get; set; }

        public int Value { get; set; }
    }
}
