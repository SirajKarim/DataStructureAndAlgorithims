using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            //pattern searching
            //int j = 0;
            //string s = "MuhammadSiraj";
            //string p = "raj";
            //int L = s.Length - p.Length;
            //for (int i = 0; i <= L; i++)
            //{
            //    for ( j = 0; j < p.Length; j++)
            //    {
            //        if (p[j] != s[i + j])
            //        {
            //            break;//andar wala loop terminate ho jae ga
            //        }
            //    }
            //    if (j == p.Length)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            string[] arr = { "m", "s", "m", "s", "s", "f", "m" };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {   
                    if (arr[i]==arr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(arr[i] +" - "+count);
            }
        }
    }
}
