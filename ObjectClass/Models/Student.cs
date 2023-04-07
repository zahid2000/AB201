using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass.Models
{
    class Student:Person
    {
        //clasin adi ile eyni olmalidi,return type -i olmur
        public Student()
        {
            Console.WriteLine("Student Created");
        }

        public Student(string name) : base(name)
        {
        }
        public Student(string name, string surname) : base(name, surname)
        {
        }
        public bool isClassMate;

      

    }

}
