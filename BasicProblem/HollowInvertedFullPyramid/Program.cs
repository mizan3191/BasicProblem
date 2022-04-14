using System;

namespace HollowInvertedFullPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Hollow Full Pyramid Hight :");
            var Hight = int.Parse(Console.ReadLine());
            var k = 0;

            for (int i = Hight; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    if (i == Hight || i <= 2)
                    {
                        Console.Write("* ");
                    }

                    else if (j == 1)
                    {
                        Console.Write("* ");
                    }


                    else if (j == i)
                    {
                        Console.Write("* ");

                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
                k = Hight;

                while (k != i - 1)
                {
                    Console.Write(" ");
                    k--;
                }
            }

        }
    }
}
