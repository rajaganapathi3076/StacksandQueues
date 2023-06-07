using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStacks linkedlistStack = new LinkedListStacks();

            linkedlistStack.Push(70);
            linkedlistStack.Push(30);
            linkedlistStack.Push(56);
            linkedlistStack.Display();
            linkedlistStack.Pop();
            
            linkedlistStack.MakingStackEmpty();
            linkedlistStack.Display();

        }
    } }
