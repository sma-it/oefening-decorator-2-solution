using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Program
    {
        static IElement content = null;

        static void Main(string[] args)
        {
            

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Create Content Object", () =>
            {
                Console.WriteLine("Add your content: ");
                string data = Console.ReadLine();
                content = new Content(data);
            });

            menu.AddOption('2', "Show Content", () =>
            {
                if (content != null)
                {
                    content.Print();
                }
                
            });

            menu.AddOption('3', "Add Parentheses", () =>
            {
                if (content != null)
                {
                    content = new Parentheses(content);
                }
            });

            menu.AddOption('4', "Add Brackets", AddBrackets);
            menu.AddOption('5', "Add Braces", AddBraces);

            menu.Start();
        }

        static void AddBrackets()
        {
            if (content != null)
            {
                content = new Brackets(content);
            }
        }

        static void AddBraces()
        {
            if (content != null)
            {
                content = new Braces(content);
            }
        }
    }
}
