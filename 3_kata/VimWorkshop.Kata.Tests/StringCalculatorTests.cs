using FluentAssertions;
using Xunit;

namespace VimWorkshop.Kata.Tests;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringShouldReturnZero()
    {
        var input = "";

        var result = new StringCalculator().Sum(input);

        result.Should().Be(0);
    }
}