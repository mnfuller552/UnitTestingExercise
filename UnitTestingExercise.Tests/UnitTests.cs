using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            //Arrange
            // create a Calculator object
            var AddCalculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = AddCalculator.Add(2, 3, 5);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5 , 10 , 5)]//Add test data <-------
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var SubtractCalculator = new Calculator();
            //Act
            var actual = SubtractCalculator.Subtract(5, 10);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var MultiplyCalculator = new Calculator();
            //Act
            var actual = MultiplyCalculator.Multiply(2, 3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5 ,  10 , 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var DivideCalculator = new Calculator();
            //Act
            var actual = DivideCalculator.Divide(5, 10);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
