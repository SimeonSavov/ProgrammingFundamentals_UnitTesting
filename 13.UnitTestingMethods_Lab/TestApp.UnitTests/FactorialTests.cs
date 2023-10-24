using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;

        // Act
        int actual = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(1, actual);
    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 3;

        // Act
        int actual = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(6, actual);
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int input = -1;

        // Act + Assert
        //int actual = Factorial.CalculateFactorial(input);
        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input); });
    }
}
