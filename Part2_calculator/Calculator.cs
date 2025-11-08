namespace Part2_calculator;

public class Calculator
{
    public double A { get; }
    public double B { get; }
    public char Op { get; }

    public Calculator(double a, double b, char op)
    {
        A = a;
        B = b;
        Op = op;
    }

    public double Compute()
    {
        if (Op == '/' && B==0) throw new DivideByZeroException();
        return Op switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => A / B,
            _=> throw new ArgumentException("Unknown operator") 
        };
    }
}