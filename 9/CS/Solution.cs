using System;
public class Solution
{
    public static void Main()
    {
        int max = 1000;
        DateTime start = DateTime.Now;
        for (int i = 1; i < max; i++) {
            for(int j = 1; j < max; j++) {
                for (int k = 1; k < max; k++) {
                    if (i + j + k == max)
                    {
                        if ((Math.Pow(i, 2) + Math.Pow(j, 2)) == Math.Pow(k, 2))
                        {
                            Console.WriteLine("{0}, {1}, {2}", i, j, k);
                            Console.WriteLine(i * j * k);
                        }
                    }
                }
            }
        }
        DateTime end = DateTime.Now;
        Console.WriteLine((end - start).TotalSeconds);
        System.Console.ReadLine();
    }
}