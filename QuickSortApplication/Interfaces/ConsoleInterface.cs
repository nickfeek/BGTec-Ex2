namespace QuickSortApplication
{
    public interface IConsoleInterface
    {
        void WriteLine(string value);
        string ReadLine();
        ConsoleKeyInfo ReadKey();
    }
}
