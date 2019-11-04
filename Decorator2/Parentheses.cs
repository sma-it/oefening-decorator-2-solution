using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Parentheses : Wrapper
    {
        public Parentheses(IElement child) : base(child) { }

        public override void Print()
        {
            Console.Write("{");
            child.Print();
            Console.Write("}");
        }
    }
}
