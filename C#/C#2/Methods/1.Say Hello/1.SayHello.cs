using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void sayHello(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            sayHello(name);
        }
    }
}
