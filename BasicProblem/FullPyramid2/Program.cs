using System;

namespace FullPyramid2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Pyramid Hight :");
            var Hight = int.Parse(Console.ReadLine());
            var k = 0;

            for (int i = 1; i <= Hight; i++)
            {
                for (int j = 1; j <= Hight - i; j++)
                {
                    Console.Write(" ");
                }

                k = 0;

                while (k != i )
                {
                    Console.Write("* ");
                    k++;
                }

                Console.WriteLine();
            }
        }
    }
}
