using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Stack
{
    class StackElement<T>
    {
        public T Inhalt { get; set; }

        public StackElement<T> FolgeElement { get; set; }
    }
}
