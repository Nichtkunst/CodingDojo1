using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Stack
{
    class Stack<T>
    {
        private StackElement<T> aktuell;

        public void Push(T input) // input 
        {
            if (aktuell == null)
            {
                aktuell = new StackElement<T>(); // aktuell wird zum ersten Stackelement
                aktuell.Inhalt = input; // weil in void Methode der input und der input wird initalisiert
                aktuell.FolgeElement = null;
            }
            else
            {
                StackElement<T> temp = new StackElement<T>();
                temp.Inhalt = input;
                temp.FolgeElement = aktuell;

                aktuell = temp;
            }
        }

        public void Peek()
        {
            if (aktuell == null)
            {
                Console.WriteLine("Stack leer!");
            }
            else
            {
                Console.WriteLine("Wert: " + aktuell.Inhalt);
            }              
        }

        public void Pop()
        {
            if (aktuell != null)
            {
                aktuell = aktuell.FolgeElement;
                Console.WriteLine("Element wurde aus dem Stack gelöscht.");
            }
            else
            {
                Console.WriteLine("Stack leer");
            }
        }
    }
}
