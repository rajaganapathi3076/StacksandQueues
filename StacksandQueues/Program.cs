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
            LinkedListQueues linkedlistQueues = new LinkedListQueues();

            linkedlistQueues.Enqueue(56);
            linkedlistQueues.Enqueue(30);
            linkedlistQueues.Enqueue(70);
            linkedlistQueues.Display();
            linkedlistQueues.Dequeue();

            linkedlistQueues.Display();
           
            
        }
    } }
