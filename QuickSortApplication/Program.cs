using System;

namespace QuickSortApplication
{
    public class Program
    {
        private readonly IConsoleInterface _console;

        public Program(IConsoleInterface console)
        {
            _console = console;
        }

        public void Run()
        {
            try
            {
                // Prompt for the number of elements to be sorted
                _console.WriteLine("Please enter the number of elements to be sorted:");
                var numElements = _console.ReadLine();

                // Ensure the input is a valid positive integer
                int num;
                while (!int.TryParse(numElements, out num) || num <= 0)
                {
                    _console.WriteLine("Invalid input.");
                    _console.WriteLine("Please enter a valid positive number:");
                    numElements = _console.ReadLine();
                }

                // Prompt the user to enter the numerical values
                _console.WriteLine($"You must now enter {num} numerical values...");

                // Create an array to hold the input values
                float[] values = new float[num];

                for (int j = 0; j < num; j++)
                {
                    // Prompt the user for each value
                    _console.WriteLine(j == 0 ? "Please enter a value:" : "Please enter another value:");
                    var elementValue = _console.ReadLine();

                    float value;
                    // Ensure each value is a valid float
                    while (!float.TryParse(elementValue, out value))
                    {
                        _console.WriteLine("Invalid input.");
                        _console.WriteLine("Please enter a valid value: ");
                        elementValue = _console.ReadLine();
                    }

                    // Store the valid float value in the array
                    values[j] = value;
                }

                // Output the input array
                _console.WriteLine("Input array: " + string.Join(", ", values));

                // Sort the array using QuickSort
                QuickSort(values, 0, values.Length - 1);

                // Output the sorted array
                _console.WriteLine("Sorted array: " + string.Join(", ", values));
            }
            catch (OutOfMemoryException e)
            {
                // Handle out of memory exceptions
                _console.WriteLine($"Error: Not enough memory to continue execution - {e.Message}");
            }
            catch (Exception e)
            {
                // Handle any unexpected exceptions
                _console.WriteLine($"Error: An unexpected error occurred - {e.Message}");
            }
            finally
            {
                // Wait for the user to press a key before exiting
                _console.WriteLine("Press any key to exit...");
                _console.ReadKey();
            }
        }

        // Method to perform QuickSort on the array
        public static void QuickSort(float[] array, int lower, int upper)
        {
            if (lower < upper)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(array, lower, upper);

                // Recursively sort the sub-arrays
                QuickSort(array, lower, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, upper);
            }
        }

        // Method to partition the array and return the pivot index
        static int Partition(float[] array, int lower, int upper)
        {
            // Choose the pivot element
            float pivot = array[upper];
            int i = lower - 1;

            for (int j = lower; j < upper; j++)
            {
                // If the current element is less than the pivot, swap it
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            // Swap the pivot element to its correct position
            Swap(array, i + 1, upper);
            return i + 1;
        }

        // Method to swap two elements in the array
        static void Swap(float[] array, int i, int j)
        {
            float temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // Main method serving as the entry point for the console application
        static void Main(string[] args)
        {
            var program = new Program(new ConsoleWrapper());
            program.Run();
        }
    }
}
