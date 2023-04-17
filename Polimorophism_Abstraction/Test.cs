using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorophism_Abstraction
{
    internal class Test
    {
       
        public void  Hello()
        {
            Console.WriteLine("Hello");
        }
        public void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
