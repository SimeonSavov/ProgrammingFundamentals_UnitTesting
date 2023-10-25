using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenArray = new int[2] { 10, 10 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenArray);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddArray = new int[2] { 9, 11 };

        // Act
        int result = EvenOddSubtraction.FindDifference(oddArray);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixedArray = new int[3] { 9, 11, 13 };

        // Act
        int result = EvenOddSubtraction.FindDifference(mixedArray);

        // Assert
        Assert.That(result, Is.EqualTo(33));
    }
}
