using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Brackets : Wrapper
    {
        public Brackets(IElement child) : base(child) { }

        public override void Print()
        {
            Console.Write("[");
            child.Print();
            Console.Write("]");
        }
    }
}
