using Part2_calculator;

namespace Part2_calculator_Tests;

public class Tests
{

    private readonly Calculator calcMult = new Calculator(4, 10, '*');
    private readonly Calculator calcDiv = new Calculator(4, 10, '/');
    private readonly Calculator calcPlus = new Calculator(4, 10, '+');
    private readonly Calculator calcMin = new Calculator(4, 10, '-');
    private readonly Calculator calcInvalidOperator = new Calculator(4, 10, '.');
    private readonly Calculator calcDivByZero = new Calculator(4, 0, '/');
    
    
    [Test]
    public void TestAddition()
    {
        Assert.That(calcPlus.Compute(), Is.EqualTo(14));
    }
    
    [Test]
    public void TestSubtraction()
    {
        Assert.That(calcMin.Compute(), Is.EqualTo(-6));
    }
    
    [Test]
    public void TestMultiplication()
    {
        Assert.That(calcMult.Compute(), Is.EqualTo(40));
    }
    
    [Test]
    public void TestDivision()
    {
        Assert.That(calcDiv.Compute(), Is.EqualTo(0.4));
    }
    
    [Test]
    public void TestDivisionByZero()
    {
        Assert.Throws<DivideByZeroException>(() => calcDivByZero.Compute());
    }
    
    [Test]
    public void TestInvalidOperator()
    {
        Assert.Throws<ArgumentException>(() => calcInvalidOperator.Compute());
    }
    
    [Test]
    public void TestConstructorProperlyStoresValues()
    {
        var calc = new Calculator(6, 7, '-');

        Assert.Multiple(() =>
        {
            Assert.That(calc.A, Is.EqualTo(6));
            Assert.That(calc.B, Is.EqualTo(7));
            Assert.That(calc.Op, Is.EqualTo('-'));
        });
    }

}