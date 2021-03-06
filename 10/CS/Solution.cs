using System;
using System.Collections.Generic;
using System.Linq;
public class Problem10
{
    public static void Main()
    {
        int max = 2000000; // Cap of primes
        DateTime start = DateTime.Now;

        // Sets for numbers (nonPrimes is easier to spell then composite)
        HashSet<int> nonPrimes = new HashSet<int>();
        HashSet<int> primes = new HashSet<int>();
        
        foreach(int i in Enumerable.Range(2,max-1)){
            /*
             * I add numbers to the two sets nonPrimes or Primes. That means the only 
             * data structure functions being called are Contains and Add, both of 
             * which happen in constant time (negating collisions).
             */
            if (!nonPrimes.Contains(i))
            {
                primes.Add(i);
                int factor = 2;
                while (i * factor <= max)
                {
                    nonPrimes.Add(i * factor);
                    factor++;
                }
            }
        }

        DateTime end = DateTime.Now;

        UInt64 sum = 0; // That number is biggggggggggg
        foreach (int i in primes)
        {
            sum += (UInt64)i;
        }


        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Sec: {0}", (end-start).TotalSeconds);
        Console.ReadLine();
    }
}
