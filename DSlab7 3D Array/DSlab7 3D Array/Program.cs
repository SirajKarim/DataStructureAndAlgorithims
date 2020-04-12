using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSlab7_3D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ,] arr = new int[2,2,2] { {{1,3},{2,4}},{{3,6},{4,8}}};
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(" {0} ",arr[i,k,j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
