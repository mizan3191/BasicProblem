using System;

namespace InvertedHalfPyramid2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hight :");
            var Hight = int.Parse(Console.ReadLine());

            for (int i = Hight; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}