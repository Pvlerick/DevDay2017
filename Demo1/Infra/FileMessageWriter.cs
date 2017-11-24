using Domain;
using System;
using System.IO;

namespace Infra
{
    public class FileMessageWriter : IMessageWriter
    {
        private readonly string outputFile;

        public FileMessageWriter(string outputFile)
        {
            this.outputFile = outputFile ?? throw new ArgumentNullException(nameof(outputFile));
        }

        public void WriteLine(string message) => File.AppendAllLines(this.outputFile, new[] { message });
    }
}
