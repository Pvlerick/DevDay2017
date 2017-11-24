using Hello;
using System;

namespace Infra
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void WriteLine(string message) => Console.WriteLine(message);
    }
}
