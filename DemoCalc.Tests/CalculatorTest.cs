using DemoCalc;
using Xunit;

public class CalculatorTests
{
    [Fact] public void Add_Works() => Assert.Equal(5, Calculator.Add(2, 3));
}