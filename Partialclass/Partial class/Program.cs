using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class
{
    class Program
    {
        static void Main(string[] args)
        {
            sumClass sc = new sumClass();
            sc.facto(5);
            sc.sum(10);
        }
    }
    partial class sumClass
    {
        public void sum(int range)
        {
            int sum = 0;
            for (int i = 0; i <range ; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
        partial class sumClass
    {
            public void facto(int range)
            {
                int fact = range;
                for (int i = 1; i < range; i++)
                {
                    fact = fact*i;
                }
                Console.WriteLine(fact);
            }
    }
}
