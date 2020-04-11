using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass<int> obj=new myClass<int>();
            obj.arr = new int[5];
            obj.add(5);
            obj.add(10);
            obj.add(15);
            obj.add(20);
            obj.add(25);
        }
    }
    class myClass<t>
    {
        public t[] arr;
            int index;
            public void add(t value)
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
    }
