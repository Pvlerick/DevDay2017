using System;

namespace Domain
{
    public class Salutations
    {
        private readonly IMessageWriter messageWriter;

        public Salutations(IMessageWriter messageWriter)
        {
            this.messageWriter = messageWriter;
        }

        public void Exclaim() => this.messageWriter.WriteLine("Hello DevDay 2017!");
    }
}
