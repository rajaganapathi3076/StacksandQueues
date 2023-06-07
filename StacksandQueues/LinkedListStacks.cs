using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StacksandQueues
{
    internal class LinkedListStacks
    {
        public Node top;

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is added at top level", data);
            }
            else
            {

                newNode.Next = top;
                top = newNode;
                Console.WriteLine("{0} is added at top level", data);
            }
        }
        public void Display()
        {
            if (top != null)
            {
                Node temp = top;
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



        public bool IsEmpty()
        {
            return top == null;
        }
}   }
