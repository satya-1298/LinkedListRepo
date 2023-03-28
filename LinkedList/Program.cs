using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListdemo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List l = new List();
            l.add(56);
            l.add(30);
            l.add(70);
            l.Display();
            Console.WriteLine("\n");
            l.InsertNode(2, 40);
            l.Display();
            Console.WriteLine("\n");
            l.RemoveNode(40);
            l.Display();
        }
    }
}