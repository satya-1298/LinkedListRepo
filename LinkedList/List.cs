using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListdemo1
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
        public void DeleteFirstNode()
        {
            Node head;
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            this.head = this.head.next;
        }
        public void DeleteLastNode()
        {
            Node tail;
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        public void SearchNode(int data)
        {
            int p = 0;
            Node temp = this.head;
            while (temp != null)
            {

                if (temp.data.Equals(data))
                {
                    Console.WriteLine("The Node " + data + " Present in Position :" + p);

                }
                temp = temp.next;
                p++;
            }
        }
        public void InsertNode(int position,int data)
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

    }
}