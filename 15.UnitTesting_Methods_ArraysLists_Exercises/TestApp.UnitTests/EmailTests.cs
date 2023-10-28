using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Net.Mail;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string email = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string email = "test.example.com";

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_WhiteSpaceEmail()
    {
        // Arrange
        string email = "     ";

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string email = null;

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}
