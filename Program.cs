using System;

namespace KnapsackGA
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(rnd.Next(1, 11));
            }
            
            
            
            Console.ReadLine();
        }
    }
}
