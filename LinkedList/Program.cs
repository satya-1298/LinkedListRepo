using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListdemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List l = new List();
            //l.add(70);
            //l.add(30);
            //l.add(56);
            
            //l.AddReverseOrder(70);
            //l.AddReverseOrder(30);
            //l.AddReverseOrder(56);
            //l.Display();
            Append a = new Append();
            a.AddNodetoFront(30);
            a.AddNodetoFront(40);
            a.AddNodetoFront(34);
            a.Display();

        }
    }
}
