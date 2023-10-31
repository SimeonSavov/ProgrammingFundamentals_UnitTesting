using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstNumberX1 = 1;
        double secondNumberY1 = 1;
        double firstNumberX2 = 2;
        double secondNumberY2 = 2;

        // Act
        string result = CenterPoint.GetClosest(firstNumberX1, secondNumberY1, firstNumberX2, secondNumberY2);

        // Assert
        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double firstNumberX1 = 2;
        double secondNumberY1 = 2;
        double firstNumberX2 = 1;
        double secondNumberY2 = 1;

        // Act
        string result = CenterPoint.GetClosest(firstNumberX1, secondNumberY1, firstNumberX2, secondNumberY2);

        // Assert
        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstNumberX1 = 2;
        double secondNumberY1 = 2;
        double firstNumberX2 = 2;
        double secondNumberY2 = 2;

        // Act
        string result = CenterPoint.GetClosest(firstNumberX1, secondNumberY1, firstNumberX2, secondNumberY2);

        // Assert
        Assert.AreEqual("(2, 2)", result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstNumberX1 = -1;
        double secondNumberY1 = -1;
        double firstNumberX2 = 2;
        double secondNumberY2 = 2;

        // Act
        string result = CenterPoint.GetClosest(firstNumberX1, secondNumberY1, firstNumberX2, secondNumberY2);

        // Assert
        Assert.AreEqual("(-1, -1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double firstNumberX1 = 2;
        double secondNumberY1 = 2;
        double firstNumberX2 = -1;
        double secondNumberY2 = -1;

        // Act
        string result = CenterPoint.GetClosest(firstNumberX1, secondNumberY1, firstNumberX2, secondNumberY2);


        // Assert
        Assert.AreEqual("(-1, -1)", result);
    }
}
