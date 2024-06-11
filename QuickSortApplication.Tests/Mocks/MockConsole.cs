using QuickSortApplication;
using System.Collections.Generic;

namespace QuickSortApplication.Tests.Mocks
{
    public class MockConsole : IConsoleInterface
    {
        private Queue<string> _inputQueue = new Queue<string>();
        private List<string> _outputList = new List<string>();

        public MockConsole(IEnumerable<string> input)
        {
            foreach (string line in input)
            {
                _inputQueue.Enqueue(line);
            }
        }

        public string ReadLine()
        {
            return _inputQueue.Dequeue();
        }

        public void WriteLine(string value)
        {
            _outputList.Add(value);
        }

        public string[] GetOutput()
        {
            return _outputList.ToArray();
        }

        // Implement the ReadKey method
        public ConsoleKeyInfo ReadKey()
        {
            // Provide a dummy implementation for ReadKey()
            return new ConsoleKeyInfo();
        }
    }
}
