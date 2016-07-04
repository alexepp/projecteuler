using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            const UInt64 n = 2000000;
            Console.WriteLine(problem10(n));
        }

        static UInt64 problem10(UInt64 n)
        {
            bool[] primes = sieve(n);
            UInt64 sum = 0;
            for (UInt64 i = 2; i < n; i++)
                if (primes[i])
                    sum += i;
            return sum;
        }

        static bool[] sieve(UInt64 n)
        {
            bool[] primes = new bool[n];
            for (UInt64 i = 2; i < n; i++)
                primes[i] = true;
            for (UInt64 i = 2; i < Convert.ToUInt32(Math.Sqrt(n))+1; i++)
            {
                if (primes[i])
                {
                    for (UInt64 j = i * i; j < n; j += i)
                        primes[j] = false;
                }
            }
            return primes;
        }
    }
}
