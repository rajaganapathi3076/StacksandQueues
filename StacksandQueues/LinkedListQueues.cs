using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class LinkedListQueues
    {
        public Node head;
        public void Enqueue(int item)
        {
            Node new_node=new Node(item);
            if(this.head == null)
            {
                this.head = new_node;

            }
            else
            {
                Node temp = this.head;
                while (temp.Next != null) 
                {
                    temp=temp.Next;
                }
                temp.Next = new_node;

            }
            Console.WriteLine("inserted into list " + new_node.Data);
        }
        public void Display()
        {
            if (head!= null)
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.Data + "  ");
                    temp = temp.Next;
                }
            }
            else
            {
                Console.WriteLine("Stacks is empty");
            }
        }
        public int Dequeue()
        {

            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int data = head.Data;
                head = head.Next;
                if (head == null)
                {
                    head = null;
                }
                return data;
            }
        }         }
}
