using System;

namespace RightHalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hight :");
            var Hight = int.Parse(Console.ReadLine());

            for(int i = 1; i <= Hight; i++)
            {
                for(var space = Hight-i; space > 0; space--)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (var i = Hight; i > 0; i--)
            {
                for(int j = Hight - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for(var k = i; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}