using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAlgorytmyIStrukturyDancyhJS
{
    class SieveOfEratosthenes
    {
        public void CalculatePrimes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int i = 0; i < prime.Length; i++)
            {
                prime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }

            for (int p = 2; p <= n; p++)
            {
                if (prime[p])
                {
                    Console.Write(p + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
