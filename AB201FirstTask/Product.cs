using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB201FirstTask
{
    //Method signature-> Method's name,method's paramters' count,method's parametr's type
    internal class human
    {
        public human()
        {
            Eat2(18,"Muslum","Hikmet");
        }
        public void Eat1(string name,string surname,string father)
        {
            Console.WriteLine("Eat apple");
        }


        public void Eat2(int age,string name,params string[] names)
        {
            Console.WriteLine("Eat apple");
        }


    }
}
