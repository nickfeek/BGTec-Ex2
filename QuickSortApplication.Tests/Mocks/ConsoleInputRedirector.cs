using System;
using System.IO;

namespace QuickSortApplication.Tests.Mocks
{
    public class ConsoleInputRedirector : IDisposable
    {
        private StringReader _stringReader;
        private TextReader _originalInput;

        public ConsoleInputRedirector(string input)
        {
            _stringReader = new StringReader(input);
            _originalInput = Console.In;
            Console.SetIn(_stringReader);
        }

        public void Dispose()
        {
            Console.SetIn(_originalInput);
            _stringReader.Dispose();
        }
    }
}
