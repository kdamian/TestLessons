using System;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var no1 = 0;
            var no2 = 10;

            while (no1 < 3)
            {
                while (no2 > 5)
                {
                    Console.WriteLine("Outer: " + no1 + "   " + "Inner: " + no2);
                    no2--;
                }
                no1++;
                no2 = 10;
            }

            Console.ReadKey();
        }
    }
}
