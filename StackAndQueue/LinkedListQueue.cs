using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace StackAndQueue
{
    class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data, int choice)
        {
            Node node = new Node(data);
            if(choice == 1)
            {
                if (head == null)
                    head = node;
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} inserted into queue ", node.data);
            }
            else if(choice == 2)
            {
                if (head == null)
                    node.next = null;
                else
                    node.next = head;
                head = node;
                Console.WriteLine("{0} inserted into queue ", node.data);
            }
            else 
            {
                Console.WriteLine("Please enter a valid input");
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
