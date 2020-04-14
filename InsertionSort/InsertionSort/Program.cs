using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 10,50,60,5,2,3};
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int temp = arr[i];
            //    int j = i - 1;
            //    while (j>=0 && temp<arr[j])
            //    {
            //        arr[j+1]=arr[j];
            //        j--;
            //    }
            //    arr[j + 1] = temp;
            //}
            int[,] multi = new int[2,2];
            int sum = 0;
            int temp;
            for (int i = 0; i < multi.GetLength(0); i++)
            {
                for (int j = 0; j < multi.GetLength(1); j++)
                {
                    multi[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < multi.GetLength(0); i++)
            {
                for (int j = 0; j < multi.GetLength(1); j++)
                {
                    Console.Write("{0} ",multi[i,j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < multi.GetLength(0); i++)
            {
                for (int j = 0; j < multi.GetLength(1); j++)
                {
                    sum = sum + multi[i, j];

                }
            }
            Console.WriteLine(sum);
        }
    }
}
