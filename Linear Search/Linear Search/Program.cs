using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter finding number");
            int target=int.Parse(Console.ReadLine());
            int[] arr = { 2,4,5,6,8,9,7,10};
            linearSearch(arr,target);
           
        }
        public static void linearSearch(int[]arr,int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine("Found");
                }
                if (arr[i]!=target)
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
