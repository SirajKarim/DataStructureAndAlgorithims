using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLab8JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length Of Array Row");
            int rL=int.Parse(Console.ReadLine());
            int[][]arr=new int[rL][];
            for (int i = 0; i < rL; i++)
            {
                Console.WriteLine("Enter Length Of inner Array");
                int iA = int.Parse(Console.ReadLine());
                arr[i]=new int [iA];
                Console.WriteLine("Enter Elements of inner array");
                for (int j = 0; j < iA; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Jagged Array");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" {0} ",arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
