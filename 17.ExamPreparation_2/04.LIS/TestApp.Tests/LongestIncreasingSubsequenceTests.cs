using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[]? array = null;

        // Act + Assert
        Assert.That(() => LongestIncreasingSubsequence.GetLis(array), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] array = new int[] { };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] array = new int[] { 1 };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.EqualTo("1"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 4, 5, 2, 3 };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 4 5"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5 };

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }
}
