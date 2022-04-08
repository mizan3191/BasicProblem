using System;

namespace HollowInvertedHalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hight :");
            var Hight = int.Parse(Console.ReadLine());

            for(int i = Hight; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(i == Hight)
                    {
                        Console.Write("* ");
                    }

                    else if(j == 1 || j == i)
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
}