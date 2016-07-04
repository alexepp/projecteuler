using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint sum = 0;
            for (uint i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
