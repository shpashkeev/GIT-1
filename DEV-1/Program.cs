using System;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Tutti-Frutti");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Tutti");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                    continue;
                }
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
