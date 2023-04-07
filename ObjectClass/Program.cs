using ObjectClass.Models;

namespace ObjectClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class 
            //string name1 = "Hikmet";
            //string surname1 = "Mehraliyev";
            //int age1 = 19;
            //string name2 = "Eli";
            //string surname2 = "Tagizade";
            //int age2 = 21;

            //Anonimous
            //var obj = new
            //{
            //    name = "hikmet"
            //};
            //var car = new
            //{
            //    color = "red",
            //    marka = "BMW"
            //};
            //var insan = new
            //{
            //    color = "red",
            //    marka = "BMW",
            //    engine=2.3
            //};

            //Console.WriteLine(obj.name);
            //Student hikmet = new Student();
            //hikmet.name = "Hikmet";
            //hikmet.surname = "Mehraliyev";
            //hikmet.age = 19;
            //Student eli = new Student();
            //eli.surname = "Eli";

            //Car car = new Car();
            //Student student = new Student();
            //student.name = "Hikmet";
            //student.surname = "Mehraliyev";
            //student.age = 19;
            //student.ShowInfo();

            //Student student1 = new Student();
            //student1.name = "Eli";
            //student1.surname = "Eliyev";
            //student1.age = 20;
            //student1.ShowInfo();
            //Student student2 = new Student();
            //student2.name = "Eli";
            //student2.surname = "Eliyev";
            //student2.age = 20;
            //student2.ShowInfo();

            //Console.WriteLine(RecurcivePrint(0)); ;

            //int RecurcivePrint(int num)
            //{
            //    if (num <= 1)
            //    {
            //        return 1;
            //    }
            //return num*RecurcivePrint(num-1);
            //}

            //int num;

            //Student student = new Student() { 
            //name="Eli",
            //surname = "Seferli",
            //age=21
            //};

            //Developer developer = new Developer()
            //{
            //    name="Hakim",
            //    surname="Hebibli",
            //    age=19,
            //};
            //student.ShowInfo();
            //developer.ShowInfo();

            //Student student = new Student()
            //{
            //    name = "Eli",
            //    surname = "Seferli",
            //    age = 21,
            //    isClassMate = true,
            //};
            //student.ShowInfo();

            //Developer developer = new Developer()
            //{
            //    name = "Muslum",
            //    surname = "Misirli",
            //    age = 20

            //};

            //developer.ShowInfo();
            //Employee employee = new Employee()
            //{
            //    name="Omer",
            //    surname="Qarayev",
            //    age = 21,
            //};

            //employee.ShowInfo();


            //Student student = new Student()
            Developer developer = new Developer("Shahin");
            #endregion

        }


    }

}