using System;

namespace HollowDiamondRectangle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Solid Diamond Even Hight :");
            var Hight = int.Parse(Console.ReadLine());
            Hight = Hight / 2;

            for(int i = 0; i < Hight; i++)
            {
                for(int j = 0; j < Hight*2; j++)
                {
                    if(i+j <= Hight - 1)
                    {
                        Console.Write("*");
                    }

                    else if(i+Hight <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for(int i = 0; i < Hight; i++)
            {
                for(int j=0; j < Hight*2; j++)
                {
                    if(i >= j)
                    {
                        Console.Write("*");
                    }
                    else if(i >= (Hight*2-1)-j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
