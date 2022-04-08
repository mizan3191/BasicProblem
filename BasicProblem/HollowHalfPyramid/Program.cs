using System;

namespace HollowHalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hight :");
            var Hight = int.Parse(Console.ReadLine());

            for(int i = 0; i < Hight; i++)
            {
                for(int j = 0; j < Hight; j++)
                {
                    if(i == 0)
                    {
                        Console.Write("* ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}