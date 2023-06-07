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
        public int Peek()
        {
            if (top != null)
            {
                Console.WriteLine("\n{0}  is topmost element in stack:",top.Data);
                return top.Data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
        }
        public void Pop()
        {
            int topData=Peek();
            if (topData != 0)
            {
                Console.WriteLine("\n{0}  is removed from the stack:", topData);
                top = top.Next;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public void MakingStackEmpty()
        {
            while(top != null)
            {
                Peek();
                Pop();
            }
            //Console.WriteLine("Stack is empty");
        }



    }   }
