// See https://aka.ms/new-console-template for more information


using Part2_calculator;

Calculator calc = new Calculator(3, 5, '-');
Console.WriteLine("3 - 5 = " + calc.Compute());
Calculator calc2 = new Calculator(3, 5, '+');
Console.WriteLine("3 + 5 = " + calc2.Compute());
Calculator calc3 = new Calculator(3, 5, '*');
Console.WriteLine("3 * 5 = " + calc3.Compute());
Calculator calc4 = new Calculator(3, 5, '/');
Console.WriteLine("3 / 5 = " + calc4.Compute());
