using System;

namespace Hello
{
    public class Salutations
    {
        private readonly IMessageWriter messageWriter;

        public Salutations(IMessageWriter messageWriter)
        {
            this.messageWriter = messageWriter ?? throw new ArgumentNullException(nameof(messageWriter));
        }

        public void Exclaim()
        {
            this.messageWriter.WriteLine("Hello DevDay 2017!");
        }
    }
}
