using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Stack.Stack;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack.Stack<int> Happy = new Stack.Stack<int>();

            Happy.Pop();
            Happy.Push(5);
            Happy.Push(15);
            Happy.Peek();
            Happy.Pop();
            Happy.Peek();
            Console.Read();
        }
    }
}
