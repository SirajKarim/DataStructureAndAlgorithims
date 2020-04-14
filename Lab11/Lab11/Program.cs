using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12,2,5,8,4,6,9,1 };
            int start = 0;
            int end = arr.Length - 1;
            while (start<end)
            {
                int min = start;
                int max = end;
                for (int i = start+1; i <= end; i++)
                {
                    if (arr[i]<arr[min])
                    {
                        min = i;
                    }  
                }
                int temp = arr[start];
                arr[start] = arr[min];
                arr[min] = temp;
                start++;
                for (int i = end-1; i >=start; i--)
                {
                    if (arr[i]>arr[max])
                    {
                        max=i;
                    }
                }
                int temp1 = arr[end];
                arr[end] = arr[max];
                arr[max] = temp1;
                end--;
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();



            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    int min = i;
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[min]>arr[j])
            //        {
            //            min = j;
            //        }
            //    }
            //    int tmp = arr[i];
            //    arr[i] = arr[min];
            //    arr[min] = tmp;

            //    foreach (var item in arr)
            //    {
            //        Console.Write(item);   
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
