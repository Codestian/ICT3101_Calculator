namespace ICT3101_Calculator.UnitTests;

public class CalculatorTests
{
    private Calculator _calculator;
    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }
    
    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }
    
    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToMinus()
    {
        // Act
        double result = _calculator.Subtract(45, 3);
        // Assert
        Assert.That(result, Is.EqualTo(42));
    }
    
    [Test]
    public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiply()
    {
        // Act
        double result = _calculator.Multiply(4, 8);
        // Assert
        Assert.That(result, Is.EqualTo(32));
    }
    
    [Test]
    public void Divide_WhenDivingTwoNumbers_ResultEqualToDivisionNoRemainder()
    {
        // Act
        double result = _calculator.Divide(8, 2);
        // Assert
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    [TestCase(0, 0)]
    [TestCase(0, 10)]
    [TestCase(10, 0)]
    public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
    {
        double result = _calculator.Divide(a, b);
        Assert.That(() => result,Throws.ArgumentException);
    }
    
    // Test Factorial of positive number
    [Test]
    public void Factorial_WithPositiveInteger_ReturnsFactorial()
    {
        double result = _calculator.Factorial(5);
        Assert.AreEqual(120, result); // 5! = 120
    }

    // Test Factorial of zero
    [Test]
    public void Factorial_WithZero_ReturnsOne()
    {
        double result = _calculator.Factorial(0);
        Assert.AreEqual(1, result); // 0! = 1
    }

    // Test Factorial of negative number (should throw exception)
    [Test]
    public void Factorial_WithNegativeNumber_ThrowsArgumentException()
    {
        Assert.That(() => _calculator.Factorial(-5), Throws.ArgumentException);
    }
}