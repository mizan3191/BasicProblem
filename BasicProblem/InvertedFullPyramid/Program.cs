using System;

namespace InvertedFullPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Full Pyramid Hight :");
            var Hight = int.Parse(Console.ReadLine());
            var k = Hight;

            for(int i = Hight; i > 0; i--)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                k = Hight;

                while (k != i-1)
                {
                    Console.Write(" ");
                    k--;
                }

                
            }

        }
    }
}
