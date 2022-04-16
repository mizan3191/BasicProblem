using System;

namespace SolidDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Solid Diamond Even Hight :");
            var Hight = int.Parse(Console.ReadLine());
            Hight = Hight/2;
            var space = 0;

            for (int i = 1; i <= Hight; i++)
            {
                for(space = 0; space <= Hight-i; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j != i; j++)
                {
                    Console.Write("* ");

                }

                Console.WriteLine();
            }

            for(int i = Hight; i > 0; i--)
            {
                for (space = i; space <= Hight; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
        }
    }
}