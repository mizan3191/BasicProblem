using System;

namespace HollowFullPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Hollow Full Pyramid Hight :");
            var Hight = int.Parse(Console.ReadLine());
            var k = 0;

            for(int i = 1; i <= Hight; i++)
            {
                for(int j = 1; j <= Hight-i; j++)
                {
                    Console.Write(" ");
                }

                for(k = 0; k != i; k++)
                {
                    if(k==0 || k == i-1 || i == Hight)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}