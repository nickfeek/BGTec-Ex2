using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSortApplication.Tests.Mocks;
using System;

namespace QuickSortApplication.Tests
{
    [TestClass]
    public class ConsoleTest
    {
        [TestMethod]
        public void TestSimpleIntegerSort()
        {
            // Arrange
            string expectedInitialMessage = "Please enter the number of elements to be sorted:";
            var inputs = new[] { "5", "5", "4", "3", "2", "1" }; // Simulated user inputs
            var mockConsole = new MockConsole(inputs);
            var program = new Program(mockConsole);

            // Act & Assert
            program.Run();

            string[] actualOutput = mockConsole.GetOutput();

            // Assert for the initial message
            Assert.IsTrue(actualOutput[0].Contains(expectedInitialMessage), $"Expected:'{expectedInitialMessage}'. Actual output:{actualOutput[0]}");

            // Assert for the "You must now enter 5 numerical values..." message
            Assert.IsTrue(actualOutput[1].Contains("You must now enter 5 numerical values..."), $"Expected:'You must now enter 5 numerical values...'. Actual output:{actualOutput[1]}");

            // Assert for the "Please enter a value:" prompt after the initial input
            Assert.IsTrue(actualOutput[2].Contains("Please enter a value:"), $"Expected:'Please enter a value:'. Actual output:{actualOutput[2]}");

            // Assert for the "Please enter another value:" prompt after each valid input
            Assert.IsTrue(actualOutput[3].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[3]}");
            Assert.IsTrue(actualOutput[4].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[4]}");
            Assert.IsTrue(actualOutput[5].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[5]}");
            Assert.IsTrue(actualOutput[6].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[6]}");

            // Assert for the "Input array:5, 4, 3, 2, 1" message
            Assert.IsTrue(actualOutput[7].Contains("Input array: 5, 4, 3, 2, 1"), $"Expected:'Input array: 5, 4, 3, 2, 1'. Actual output:{actualOutput[7]}");

            // Assert for the "Sorted array:1, 2, 3, 4, 5" message
            Assert.IsTrue(actualOutput[8].Contains("Sorted array: 1, 2, 3, 4, 5"), $"Expected:'Sorted array: 1, 2, 3, 4, 5'. Actual output:{actualOutput[8]}");

            // Assert for the "Press any key to exit..." message
            Assert.IsTrue(actualOutput[9].Contains("Press any key to exit..."), $"Expected:'Press any key to exit...'. Actual output:{actualOutput[9]}");
        }

        [TestMethod]
        public void TestSimpleFloatSort()
        {
            // Arrange
            string expectedInitialMessage = "Please enter the number of elements to be sorted:";
            var inputs = new[] { "5", "5.1", "4.2", "3.3", "2.4", "1.5" }; // Simulated user inputs
            var mockConsole = new MockConsole(inputs);
            var program = new Program(mockConsole);

            // Act & Assert
            program.Run();

            string[] actualOutput = mockConsole.GetOutput();

            // Assert for the initial message
            Assert.IsTrue(actualOutput[0].Contains(expectedInitialMessage), $"Expected:'{expectedInitialMessage}'. Actual output:{actualOutput[0]}");

            // Assert for the "You must now enter 5 numerical values..." message
            Assert.IsTrue(actualOutput[1].Contains("You must now enter 5 numerical values..."), $"Expected:'You must now enter 5 numerical values...'. Actual output:{actualOutput[1]}");

            // Assert for the "Please enter a value:" prompt after the initial input
            Assert.IsTrue(actualOutput[2].Contains("Please enter a value:"), $"Expected:'Please enter a value:'. Actual output:{actualOutput[2]}");

            // Assert for the "Please enter another value:" prompt after each valid input
            Assert.IsTrue(actualOutput[3].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[3]}");
            Assert.IsTrue(actualOutput[4].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[4]}");
            Assert.IsTrue(actualOutput[5].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[5]}");
            Assert.IsTrue(actualOutput[6].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[6]}");

            // Assert for the "Input array:5.1, 4.2, 3.3, 2.4, 1.5" message
            Assert.IsTrue(actualOutput[7].Contains("Input array: 5.1, 4.2, 3.3, 2.4, 1.5"), $"Expected:'Input array: 5.1, 4.2, 3.3, 2.4, 1.5'. Actual output:{actualOutput[7]}");

            // Assert for the "Sorted array:1.5, 2.4, 3.3, 4.2, 5.1" message
            Assert.IsTrue(actualOutput[8].Contains("Sorted array: 1.5, 2.4, 3.3, 4.2, 5.1"), $"Expected:'Sorted array: 1.5, 2.4, 3.3, 4.2, 5.1'. Actual output:{actualOutput[8]}");

            // Assert for the "Press any key to exit..." message
            Assert.IsTrue(actualOutput[9].Contains("Press any key to exit..."), $"Expected:'Press any key to exit...'. Actual output:{actualOutput[9]}");
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            // Arrange
            string expectedInitialMessage = "Please enter the number of elements to be sorted:";
            var inputs = new[] { "3", "invalid", "5", "3", "4" }; // Simulated user inputs
            var mockConsole = new MockConsole(inputs);
            var program = new Program(mockConsole);

            // Act & Assert
            program.Run();

            string[] actualOutput = mockConsole.GetOutput();

            // Assert for the initial message
            Assert.IsTrue(actualOutput[0].Contains(expectedInitialMessage), $"Expected:'{expectedInitialMessage}'. Actual output:{actualOutput[0]}");

            // Assert for the "You must now enter 3 numerical values..." message
            Assert.IsTrue(actualOutput[1].Contains("You must now enter 3 numerical values..."), $"Expected:'You must now enter 3 numerical values...'. Actual output:{actualOutput[1]}");

            // Assert for the "Please enter a value:" prompt after the initial input
            Assert.IsTrue(actualOutput[2].Contains("Please enter a value:"), $"Expected:'Please enter a value:'. Actual output:{actualOutput[2]}");

            // Assert for the "Invalid input." message
            Assert.IsTrue(actualOutput[3].Contains("Invalid input."), $"Expected:'Invalid input.'. Actual output:{actualOutput[3]}");

            // Assert for the "Please enter a valid value:" prompt after invalid input
            Assert.IsTrue(actualOutput[4].Contains("Please enter a valid value:"), $"Expected:'Please enter a valid value:'. Actual output:{actualOutput[4]}");

            // Assert for the "Please enter another value:" prompt after each valid input
            Assert.IsTrue(actualOutput[5].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[5]}");
            Assert.IsTrue(actualOutput[6].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[6]}");

            // Assert for the "Input array:5, 3, 4" message
            Assert.IsTrue(actualOutput[7].Contains("Input array: 5, 3, 4"), $"Expected:'Input array: 5, 3, 4'. Actual output:{actualOutput[7]}");

            // Assert for the "Sorted array:3, 4, 5" message
            Assert.IsTrue(actualOutput[8].Contains("Sorted array: 3, 4, 5"), $"Expected:'Sorted array: 3, 4, 5'. Actual output:{actualOutput[8]}");

            // Assert for the "Press any key to exit..." message
            Assert.IsTrue(actualOutput[9].Contains("Press any key to exit..."), $"Expected:'Press any key to exit...'. Actual output:{actualOutput[9]}");
        }

        [TestMethod]
        public void TestInvalidNUmberOfElementsInputNonNumeric()
        {
            // Arrange
            string expectedInitialMessage = "Please enter the number of elements to be sorted:";
            var inputs = new[] { "invalid", "2", "4", "3" }; // Simulated user inputs
            var mockConsole = new MockConsole(inputs);
            var program = new Program(mockConsole);

            // Act & Assert
            program.Run();

            string[] actualOutput = mockConsole.GetOutput();

            // Assert for the initial message
            Assert.IsTrue(actualOutput[0].Contains(expectedInitialMessage), $"Expected:'{expectedInitialMessage}'. Actual output:{actualOutput[0]}");

            // Assert for the "Invalid input." message
            Assert.IsTrue(actualOutput[1].Contains("Invalid input."), $"Expected:'Invalid input.'. Actual output:{actualOutput[1]}");

            // Assert for the "Please enter a valid positive number:" message
            Assert.IsTrue(actualOutput[2].Contains("Please enter a valid positive number:"), $"Expected:'Please enter a valid positive number:'. Actual output:{actualOutput[2]}");
            
            // Assert for the "You must now enter 3 numerical values..." message
            Assert.IsTrue(actualOutput[3].Contains("You must now enter 2 numerical values..."), $"Expected:'You must now enter 2 numerical values...'. Actual output:{actualOutput[3]}");

            // Assert for the "Please enter a value:" prompt after the initial input
            Assert.IsTrue(actualOutput[4].Contains("Please enter a value:"), $"Expected:'Please enter a value:'. Actual output:{actualOutput[4]}");

            // Assert for the "Please enter another value:" prompt after each valid input
            Assert.IsTrue(actualOutput[5].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[5]}");

            // Assert for the "Input array:5, 3, 4" message
            Assert.IsTrue(actualOutput[6].Contains("Input array: 4, 3"), $"Expected:'Input array: 3, 4'. Actual output:{actualOutput[6]}");

            // Assert for the "Sorted array:3, 4, 5" message
            Assert.IsTrue(actualOutput[7].Contains("Sorted array: 3, 4"), $"Expected:'Sorted array: 3, 4'. Actual output:{actualOutput[7]}");

            // Assert for the "Press any key to exit..." message
            Assert.IsTrue(actualOutput[8].Contains("Press any key to exit..."), $"Expected:'Press any key to exit...'. Actual output:{actualOutput[8]}");
        }


        [TestMethod]
        public void TestInvalidNUmberOfElementsInputNegative()
        {
            // Arrange
            string expectedInitialMessage = "Please enter the number of elements to be sorted:";
            var inputs = new[] { "-2", "2", "4", "3" }; // Simulated user inputs
            var mockConsole = new MockConsole(inputs);
            var program = new Program(mockConsole);

            // Act & Assert
            program.Run();

            string[] actualOutput = mockConsole.GetOutput();

            // Assert for the initial message
            Assert.IsTrue(actualOutput[0].Contains(expectedInitialMessage), $"Expected:'{expectedInitialMessage}'. Actual output:{actualOutput[0]}");

            // Assert for the "Invalid input." message
            Assert.IsTrue(actualOutput[1].Contains("Invalid input."), $"Expected:'Invalid input.'. Actual output:{actualOutput[1]}");

            // Assert for the "Please enter a valid positive number:" message
            Assert.IsTrue(actualOutput[2].Contains("Please enter a valid positive number:"), $"Expected:'Please enter a valid positive number:'. Actual output:{actualOutput[2]}");

            // Assert for the "You must now enter 3 numerical values..." message
            Assert.IsTrue(actualOutput[3].Contains("You must now enter 2 numerical values..."), $"Expected:'You must now enter 2 numerical values...'. Actual output:{actualOutput[3]}");

            // Assert for the "Please enter a value:" prompt after the initial input
            Assert.IsTrue(actualOutput[4].Contains("Please enter a value:"), $"Expected:'Please enter a value:'. Actual output:{actualOutput[4]}");

            // Assert for the "Please enter another value:" prompt after each valid input
            Assert.IsTrue(actualOutput[5].Contains("Please enter another value:"), $"Expected:'Please enter another value:'. Actual output:{actualOutput[5]}");

            // Assert for the "Input array:5, 3, 4" message
            Assert.IsTrue(actualOutput[6].Contains("Input array: 4, 3"), $"Expected:'Input array: 3, 4'. Actual output:{actualOutput[6]}");

            // Assert for the "Sorted array:3, 4, 5" message
            Assert.IsTrue(actualOutput[7].Contains("Sorted array: 3, 4"), $"Expected:'Sorted array: 3, 4'. Actual output:{actualOutput[7]}");

            // Assert for the "Press any key to exit..." message
            Assert.IsTrue(actualOutput[8].Contains("Press any key to exit..."), $"Expected:'Press any key to exit...'. Actual output:{actualOutput[8]}");

        }

    }
}
