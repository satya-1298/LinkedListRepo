using System;
using System.Collections.Generic;

namespace LinkedListdemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List linkedlist = new List();
            //linkedlist.add(30);
            //linkedlist.add(70);
            //linkedlist.add(56);
           
            linkedlist.AddReverseOrder(70);
            linkedlist.AddReverseOrder(30);
            linkedlist.AddReverseOrder(56);
            linkedlist.Display();

        }
    }
}