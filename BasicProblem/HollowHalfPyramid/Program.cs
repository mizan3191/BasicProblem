using System;

namespace HollowHalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hight :");
            var Hight = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < Hight; i++)
            {
                for(int j = 0; j <= i ; j++)
                {
                    if(i == Hight-1)
                    {
                        Console.Write("* ");
                    }

                    else if(j == 0 || j==i)
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