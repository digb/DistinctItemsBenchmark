using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DistinctItemsBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            // Benchmark 1
            stopwatch.Restart();
            HashSet();
            stopwatch.Stop();

            Console.WriteLine($"Benchmark 1 runs for {stopwatch.Elapsed}");

            // Benchmark 2
            stopwatch.Restart();
            ListContains();
            stopwatch.Stop();

            Console.WriteLine($"Benchmark 2 runs for {stopwatch.Elapsed}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        static void HashSet()
        {
            HashSet<string> uniqueItems = new HashSet<string>();

            for (int i = 0; i < 100000; i++)
            {
                var str = (i % 1000).ToString();
                uniqueItems.Add(str);
            }
        }

        static void ListContains()
        {
            List<string> uniqueItems = new List<string>();

            for (int i = 0; i < 100000; i++)
            {
                var str = (i % 1000).ToString();
                if (!uniqueItems.Contains(str))
                {
                    uniqueItems.Add(str);
                }
            }
        }
    }
}
