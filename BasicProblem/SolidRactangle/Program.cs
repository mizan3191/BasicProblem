using System;

namespace SolidRactangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hight :");
            var Hight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your width :");
            var Width = int.Parse(Console.ReadLine());

            for(int i = 0; i < Hight; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}