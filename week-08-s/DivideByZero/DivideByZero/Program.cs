using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            try
            {
                Console.Write("Input a number: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"{ a }/{ b }" + " = " + a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("fail, attempt divided by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
