// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using static Types.Task00;
namespace Types;

class Program
{
    public static void Main()
    {
        //Task00.Run();
        //Task01.Run();
        /*        int num1 = 2;
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
        */

        //double num1 = 2.2;
        //decimal num2 = 4.9m;

        //Console.WriteLine(MultiplyInt((int)num1, (int)num2));
        //DivideIntandDecimal();

        Duck myFavouriteDuck = new Duck();
        myFavouriteDuck.Quack();

    }

    public static int MultiplyInt(int num1, int num2)
    {
        return num1 * num2;
    }

    public static void DivideIntandDecimal()
    {
        int num1;
        decimal num2;
        double num3;

        Console.WriteLine("Enter integer");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter decimal");
        num2 = decimal.Parse(Console.ReadLine());
        //num3 = (num1 / num2);

        Console.WriteLine((double)(num1 / num2));
 
    }

}
