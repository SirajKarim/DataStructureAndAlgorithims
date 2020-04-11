using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.swap<int>(59, 5);
        }
    }
    class myClass
    {
        public void swap<t>(t a, t b)
        {
            t c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
