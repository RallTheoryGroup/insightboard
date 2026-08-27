using Xunit;
using InsightBoard.Core;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var calc = new Calculator();
        Assert.Equal(1, calc.Subtract(3, 2));
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        var calc = new Calculator();
        Assert.Equal(12, calc.Multiply(3, 4));
    }

    [Fact]
    public void Divide_ReturnsCorrectQuotient()
    {
        var calc = new Calculator();
        Assert.Equal(5.0, calc.Divide(10, 2));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }

    [Fact]
    public void Percentage_ReturnsCorrectValue()
    {
        var calc = new Calculator();
        Assert.Equal(25.0, calc.Percentage(50, 200));
    }

    [Fact]
    public void Percentage_ByZeroTotal_ThrowsException()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Percentage(10, 0));
    }
}
