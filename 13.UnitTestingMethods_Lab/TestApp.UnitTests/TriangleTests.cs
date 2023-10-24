using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int input = 0;

        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual("", actual);

    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int input = 3;
        string expectedOutput = "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";
        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual(expectedOutput, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int input = 5;
        string expectedOutput = "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";
        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual(expectedOutput, actual);
    }
}
