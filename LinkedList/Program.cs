using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListdemo
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            List l= new List();
            l.add(70);
            l.add(56);
            l.Display();
            l.InsertAtPosition(1, 30);
            l.Display();
            l.DeleteFirstNode();
            l.Display();
        }

    }
}
