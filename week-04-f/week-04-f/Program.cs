using System;

namespace week_04_f
{
    class Program
    {
        static void Main(string[] args)
        {
            // third
            int[] q = { 4, 5, 6, 7 };

            Console.WriteLine(q[2]);
            Console.WriteLine("\r");


            // compare length
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };
            if (p2.Length > p1.Length)
            {
                Console.WriteLine("p2 is longer");
            }
            else
            {
                Console.WriteLine("p2 is not longer");
            }
            Console.WriteLine();

            // sum elements
            int[] r = { 54, 23, 66, 12 };
            Console.WriteLine(r[1] + r[2]);
            Console.WriteLine("\r");

            // change elements
            int[] s = { 1, 2, 3, 8, 5, 6 };
            s[3] = 4;
            Console.WriteLine(s[3]);
            Console.WriteLine("\r");

            // increment elements
            int[] t = { 1, 2, 3, 4, 5 };
            t[2]++;
            Console.WriteLine(t[2]);
            Console.WriteLine("\r");

            // print all
            int[] numbers = { 4, 5, 6, 7 };

            foreach (int item in numbers)
            {
                Console.Write(item);
            }

            Console.WriteLine("\n");

            // matrix
            int[,] array2D = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        array2D[i, j] = 1;
                    }
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\r");

            // double items
            int[] numList = { 3, 4, 5, 6, 7 };
            foreach (int numb in numList)
            {
                Console.Write(numb * 2 + ", ");
            }
            Console.WriteLine("\n");

            // colors
            string[][] colors = new string[3][];
            colors[0] = new string[] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new string[] { "orange red", "red", "tomato" };
            colors[2] = new string[] { "orchid", "violet", "pink", "hot pink" };

            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < colors[i].Length; j++)
                    Console.Write(colors[i][j] + ", ");
                Console.WriteLine();
            }
            //foreach (string[] color in colors)
            //{
            //    foreach (string i in color)
            //        Console.Write(i + ", ");
            //    Console.WriteLine();
            //}
            Console.WriteLine("\r");

            // append a
            string[] animals = { "koal", "pand", "zebr" };
            foreach (string animal in animals)
            {
                Console.WriteLine(animal + "a");
            }
            Console.WriteLine("\r");

            // swap elements
            string[] abc = { "first", "second", "third" };
            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;
            foreach (string word in abc)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\r");

            // sum all
            int[] ai = { 3, 4, 5, 6, 7 };
            int sum = 0;
            foreach (int sumAll in ai)
            {
                sum += sumAll;
            }
            Console.WriteLine(sum);
            Console.WriteLine("\r");

            // reverse
            int[] aj = { 3, 4, 5, 6, 7 };
            Array.Reverse(aj);
            foreach (int num in aj)
            {
                Console.Write(num);
            }
            Console.WriteLine("\r");
        }
    }
}
