using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {

            //    int a = 10;
            //    try
            //    {
            //        Console.Write("Input a number: ");
            //        int b = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"{ a }/{ b }" + " = " + a / b);
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("fail, attempt divided by zero");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("wrong input");
            //    }
            //}
            DivideByZero();
        }
        static void DivideByZero()
        {
            int divider = 10;
            int userNumberInput;
            int result;
            char userInput;
            while (true)
            {
                try
                {
                    Console.Write("Please enter a number: ");
                    userNumberInput = Int32.Parse(Console.ReadLine());
                    result = divider / userNumberInput;
                    Console.WriteLine(result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("fail, attempt divided by zero");
                }
                catch (FormatException)
                {
                    Console.WriteLine("wrong input");
                }
                Console.WriteLine(@"You want repeat? press ""y"" if yes and ""n"" if no :");
                userInput = Console.ReadKey(true).KeyChar;
                if (userInput == 'y')
                {
                    continue;
                }
                if (userInput == 'n')
                {
                    break;
                }
            }
        }
    }
}

