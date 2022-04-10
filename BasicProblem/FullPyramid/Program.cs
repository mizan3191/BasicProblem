using System;

namespace FullPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Pyramid Hight :");
            var Hight = int.Parse(Console.ReadLine());
            var k = 0;

            for(int i = 1; i <= Hight; i++, k=0)
            {
                for(int j = 1; j <= Hight-i; j++)
                {
                    Console.Write("  ");
                }

                while(k != 2*i - 1)
                {
                    Console.Write("* ");
                    k++;
                }

                Console.WriteLine();
            }
        }
    }
}