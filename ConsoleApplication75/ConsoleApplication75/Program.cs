using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication75
{
    class Program
    {
        static void Main(string[] args)
        {
            CQueue cq = new CQueue();
            cq.Enqueue(1);
            cq.Enqueue(2);
            cq.Enqueue(3);
            cq.Dequeue();
            Console.WriteLine(cq.Peekfront());
            
        }
    }
    class CQueue : CollectionBase
    {
        public void Enqueue(object item)
        {
            InnerList.Add(item);
        }
        public void Dequeue()
        {
            InnerList.RemoveAt(0);
        }
        public object Peekfront()
        {
            return InnerList[0];
        }
    }
}
