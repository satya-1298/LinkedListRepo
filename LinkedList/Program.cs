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
            l.add(70);
            l.add(56);
            l.Display();
            Console.WriteLine("\n");
            l.InsertAtPosition(1, 30);
            l.Display();
            //Console.WriteLine("\n");
            //l.DeleteFirstNode();
            //l.Display();
            //Console.WriteLine("\n");
            //l.DeleteLastNode();
            //l.Display();
            Console.WriteLine("\n");
            l.SearchNode(70);
            l.Display();
        }

    }
}
