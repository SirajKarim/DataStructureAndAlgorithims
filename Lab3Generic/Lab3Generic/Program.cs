using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3Generic
{
    class Program
    {
        //class MyClass <y>
        //{
        //    //public void print<t>(t value)
        //    //{
        //    //    Console.WriteLine(value);
        //    //}
        //}
        class class1<t>
        {
            public t[] arr;
            int index;
            public void Add(t value)
            {
                arr[index] = value;
                index++;
            }
            public void print()
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            //MyClass<int> p = new MyClass<int>();
            //p.print<string>("Hello World");
            //methodPrint<string,int,int>("Muhammad Siraj",2075421,3536421);
            class1<int> c = new class1<int>();
            c.arr=new int[5];
            c.Add(5);
            c.Add(6);
            c.Add(7);
            c.Add(9);
            c.print();
            
        }
        //public static void methodPrint<t,z,y>(t val,z value,y val1)
        //{
        //    Console.WriteLine("{0},{1},{2}",val,value,val1);
        //    Console.WriteLine(value);

        //}
    }
}
