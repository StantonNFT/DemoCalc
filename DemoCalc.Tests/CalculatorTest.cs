diff --git a/DemoCalc.Tests/CalculatorTest.cs b/DemoCalc.Tests/CalculatorTest.cs
index 71ce591..4bb0c77 100644
 public class CalculatorTests
 {
     [Fact] public void Add_Works() => Assert.Equal(5, Calculator.Add(2, 3));
    
    [Fact]
    public void Multiply_BasicNumbers_Works() => Assert.Equal(6, Calculator.Multiply(2, 3));
    
    [Fact]
    public void Multiply_ByZero_ReturnsZero() => Assert.Equal(0, Calculator.Multiply(5, 0));
    
    [Fact]
    public void Multiply_NegativeNumbers_Works()
    {
        Assert.Equal(12, Calculator.Multiply(-3, -4));  // negative * negative = positive
        Assert.Equal(-15, Calculator.Multiply(3, -5));  // positive * negative = negative
        Assert.Equal(-15, Calculator.Multiply(-3, 5));  // negative * positive = negative
    }
    
 }