using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListdemo
{
    public class Append
    {
        
         public Node head;
       public   void AddNodetoFront(int data)
        {
            
            Node n = new Node(data);
            if(this.head == null) 
            {
               
                this.head = n;
            }
            else 
            {
                Node temp = head;
                head = n;
                head.next = temp;
            }
            Console.WriteLine(data);
            

        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}
