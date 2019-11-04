using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Content : IElement
    {
        string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Print()
        {
            Console.Write(content);
        }
    }
}
