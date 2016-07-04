using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(problem2(4000000));
        }

        static uint problem2(uint n)
        {
            uint sum = 0;
            uint f1 = 1, f2 = 1, fn = 1;

            while (f1 < n)
            {
                if (fn % 2 == 0)
                    sum += fn;
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
            }

            return sum;
        }
    }
}
