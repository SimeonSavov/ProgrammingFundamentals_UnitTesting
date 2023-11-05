using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char one = 'A';
        char two = 'B';

        // Act
        string result = CharacterRange.GetRange(one, two);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char one = 'B';
        char two = 'A';

        // Act
        string result = CharacterRange.GetRange(one, two);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char one = 'A';
        char two = 'C';

        // Act
        string result = CharacterRange.GetRange(one, two);

        // Assert
        Assert.That(result, Is.EqualTo("B"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char one = 'D';
        char two = 'G';

        // Act
        string result = CharacterRange.GetRange(one, two);

        // Assert
        Assert.That(result, Is.EqualTo("E F"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char one = 'X';
        char two = 'Z';

        // Act
        string result = CharacterRange.GetRange(one, two);

        // Assert
        Assert.That(result, Is.EqualTo("Y"));
    }
}
