using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMulitiDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Rows and Coloums of Matrix");
            int r = int.Parse(Console.ReadLine());  //for Rows
            int c = int.Parse(Console.ReadLine());  //for Coloums
            int[,]arr=new int[r,c];                //array for first Matrix
            Console.WriteLine("Enter Elements of First Matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine()); 
                }
            }
            Console.WriteLine("First Matrix is :");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" {0} ",arr[i,j]);
                }
                Console.WriteLine();
            }
            int[,]brr = new int[r, c];
            Console.WriteLine("Enter Elements of Second Matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    brr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" {0} ", brr[i, j]);
                }
                Console.WriteLine();
            }

            int[,]crr=new int[r,c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    crr[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        crr[i, j] += arr[i, j] * brr[j, i];
                    }
                }
            }

            Console.WriteLine("Multilication of Matrix is:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" {0} ", crr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
