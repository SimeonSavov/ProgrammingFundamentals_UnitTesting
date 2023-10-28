using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] arr = new char[] {'0', '1', 'a', 'b' };

        // Act
        char[] result = Fake.RemoveStringNumbers(arr);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b' }));

    }

    [Test]
    public void Test_RemoveStringNumbers_OnlyDigits_ReturnsEmptyArray()
    {
        // Arrange
        char[] arr = new char[] { '0', '1', '2', '3' };

        // Act
        char[] result = Fake.RemoveStringNumbers(arr);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] arr = new char[] { 'a', 'b', 'c', 'd' };

        // Act
        char[] result = Fake.RemoveStringNumbers(arr);

        // Assert
        Assert.That(result, Is.EqualTo(arr));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] arr = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(arr);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
