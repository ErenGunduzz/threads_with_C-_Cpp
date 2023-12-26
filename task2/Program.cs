using System.Runtime.InteropServices;

public class Program
{
    [DllImport("Calc.dll")]
    public static extern int Multiply(int n1, int n2);

    public static void Main()
    {
        Console.Write("Num1: ");
        var num1 = Console.ReadLine();

        Console.Write("\nNum2: ");
        var num2 = Console.ReadLine();

        int result = Multiply(int.Parse(num1), int.Parse(num2));

        Console.WriteLine($"Result after calling C++, multiplying {num1} and {num2} is {result}");
    }
}
