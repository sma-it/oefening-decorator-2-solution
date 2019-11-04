using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    abstract class Wrapper : IElement
    {
        protected  IElement child;

        public Wrapper(IElement child)
        {
            this.child = child;
        }

        public abstract void Print();
    }
}
