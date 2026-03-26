using System;

public class Program
{
    public static string Evaluate(string expression)
    {
        var parts = expression.Split(' ');
        if (parts.Length != 3) return "Error:InvalidExpression";

        if (!int.TryParse(parts[0], out int a) || !int.TryParse(parts[2], out int b))
            return "Error:InvalidNumber";

        string op = parts[1];

        return op switch
        {
            "+" => (a + b).ToString(),
            "-" => (a - b).ToString(),
            "*" => (a * b).ToString(),
            "/" => b == 0 ? "Error:DivideByZero" : (a / b).ToString(),
            _ => "Error:UnknownOperator"
        };
    }

    public static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        Console.WriteLine(Evaluate(expression));
    }
}