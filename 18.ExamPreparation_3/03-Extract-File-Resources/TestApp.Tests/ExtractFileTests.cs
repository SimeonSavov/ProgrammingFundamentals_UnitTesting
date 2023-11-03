using NUnit.Framework;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string? path = null;

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = string.Empty;

        // Act + Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Users\\file.txt";

        string expected = "File name: file\nFile extension: txt";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string input = "C:\\Users\\file";

        string expected = "File name: file";

        // Act
        string result = ExtractFile.GetFile(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string input = "C:\\U%se-r.s\\file.txt";

        string expected = "File name: file\nFile extension: txt";

        // Act
        string result = ExtractFile.GetFile(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
