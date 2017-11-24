using Hello;
using System.IO;

namespace Infra
{
    public class FileMessageWriter : IMessageWriter
    {
        private readonly string filePath;

        public FileMessageWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public void WriteLine(string message) => File.WriteAllLines(this.filePath, new[] { message });
    }
}
