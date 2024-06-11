using System;

namespace QuickSortApplication
{
    public class ConsoleWrapper : IConsoleInterface
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public ConsoleKeyInfo ReadKey()
        {
            ConsoleKeyInfo keyInfo;

            // Read the key from the console
            var keyChar = Console.ReadKey().KeyChar;

            // Create a ConsoleKeyInfo object representing the key pressed
            keyInfo = new ConsoleKeyInfo(keyChar, (ConsoleKey)0, false, false, false);

            return keyInfo;
        }
    }
}
