using System;

namespace HollowDiamondRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Solid Diamond Even Hight :");
            var Hight = int.Parse(Console.ReadLine());
            Hight = Hight / 2;
            var star = 0;

            for(int i = 1; i <= Hight; i++)
            {
                for(star = Hight; star >= i; star--)
                {
                    Console.Write("*");
                }

                for(int j = i; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                for(var j = i; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                for (star = Hight; star >= i; star--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
