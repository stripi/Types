// See https://aka.ms/new-console-template for more information
using static Types.Task00;
namespace Types;

class Program
{
    public static void Main()
    {
        // Task00.Run();
        // Task01.Run();
        int num1 = 2;
        decimal dec1 = 1.1m;
        float float1 = 2.9f;
        float float2 = 3.95f;
        double double1 = 3.678908765436578;

        decimal numberToDecimal = num1;
        double decimalToDouble = (double)dec1;
        int floatToInt = (int)float1;
        decimal floatToDecimal = (decimal)float2;
        float doubleToFloat = (float)double1;

        Console.WriteLine($"{numberToDecimal}, {decimalToDouble}, {floatToInt}, {floatToDecimal}, {doubleToFloat}");

    }
}
