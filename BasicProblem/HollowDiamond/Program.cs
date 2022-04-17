using System;

namespace HollowDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Solid Diamond Even Hight :");
            var Hight = int.Parse(Console.ReadLine());
            Hight = Hight / 2;

            var space = 0;


            for (int i = 1; i <= Hight; i++)
            {
                for(space = i; space < Hight; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j != i+1; j++)
                {
                    if(j == 1 || j == i)
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

            for (int i = Hight; i > 0; i--)
            {
                for (space = i; space < Hight; space++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j>0; j--)
                {
                    if (j == 1 || j == i || i <= 2)
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
