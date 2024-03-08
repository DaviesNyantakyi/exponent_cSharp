using System;
class MyApp
{

    class Program
    {
        static void Main()
        {
            double number1 = 0;
            double number2 = 0;
            double result = 0;

            // Aks user for base and exponent number
            Console.Write("enter the base number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter exponent: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            //Calculate the expont
            result = Calculate(number1, number2);
            Console.WriteLine(result);
        }

        static double Calculate(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }
    }
}

