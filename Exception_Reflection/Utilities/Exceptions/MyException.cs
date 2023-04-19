using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Reflection.Utilities.Exceptions
{
    internal class MyException:Exception
    {

        public MyException(string mesaage):base(mesaage)
        {
            
        }

    }
}
