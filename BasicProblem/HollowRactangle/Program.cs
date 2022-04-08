using System;

namespace HollowRactangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hight :");
            var Hight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your width :");
            var Width = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < Hight; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    if(i == 0 || i == Hight-1)
                    {
                        Console.Write("* ");
                    }

                    else if(j == 0 || j == Width - 1)
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