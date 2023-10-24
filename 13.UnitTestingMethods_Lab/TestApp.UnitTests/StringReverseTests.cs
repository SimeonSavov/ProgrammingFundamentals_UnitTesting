using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = ""; // string.Empty --> is the same as a "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "X";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert

        Assert.AreEqual("X", result);
        Assert.AreEqual(1, result.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "XYZ";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("ZYX", actual);
        Assert.AreEqual(input.Length, actual.Length); // It should be same length as the expected
    }
}
