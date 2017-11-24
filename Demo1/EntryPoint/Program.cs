using Hello;
using Infra;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Salutations(new FileMessageWriter("hello.txt"));
            s.Exclaim();
        }
    }
}
