using Domain;
using Infra;
using System;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Salutations(new FileMessageWriter("output.txt"));
            s.Exclaim();
        }
    }
}
