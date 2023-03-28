using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListdemo
{
    public class List
    {
        public Node head;
        public void add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine("{0} inserted into Linked List", data);

        }
       
        public void InsertAtPosition(int position, int data)
        {
                Node n = new Node(data);
                if (this.head == null)
                    this.head = n;
                if (position == 0)
                {
                    n.next = head;
                    head = n;
                    return;
                }
                Node prev = null;
                Node current = this.head;
                int count = 0;
                while (current != null && count < position)
                {
                    prev = current;
                    current = current.next;
                    count++;
                }
                n.next = prev.next;
                prev.next = n;
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