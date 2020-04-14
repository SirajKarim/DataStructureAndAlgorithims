using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class linkedList
    {
        class Node
        {
            public int data;
            public Node link;
        }
        public Node head;
        public Node tail;
        public int size;
        public void Add(int _data)
        {
            size++;
            Node newnode = new Node();
            newnode.data = _data;
            if (head==null)
            {
                head= newnode;
            }
            else
            {
                tail.link = newnode;
            }
            tail = newnode;

        }
        public void printAll()
        {
            Node temp = head;
            while (head!=null)
            {
                Console.WriteLine(temp.data);
                tail = temp.link;
            }
        }
    }
}
