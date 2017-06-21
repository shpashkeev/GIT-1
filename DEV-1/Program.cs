using System;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String output;
            for (int i=0; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    output = "3*" + (i / 3).ToString();
                }
                else
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    }
}
