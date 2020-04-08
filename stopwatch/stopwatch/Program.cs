using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Restart();
            foreach (var item in arr)
            {
                
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.Read();
        }
    }
}
