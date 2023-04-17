namespace Polimorophism_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Abstract Class,Abstract Method
            //Animal animal = new Animal();
            ////Bird bird = new Bird(); 
            //Animal eagle = new Eagle();
            ////eagle.Fly();
            ////eagle.Eat();
            ////eagle.See();

            //Animal shark = new Shark();
            ////shark.Swim();
            ////shark.Eat();
            ////shark.See();

            //Animal[] animals = new Animal[] { eagle, shark };
            //foreach (var animal in animals)
            //{
            //    animal.Eat();
            //    animal.See();
            //}
            //Shark shark = new Shark();
            //shark.See();
            //GoldFish goldFish = new GoldFish(); 
            //goldFish.See();

            //Test test = new Test();
            //test.Hello()
            //GoldFish goldFish = new GoldFish();
            //Shark shark1=new Shark();
            //Fish[] fishes = new Fish[] {goldFish,shark1};
            //foreach (var fish in fishes)
            //{
            //    fish.Eat();
            //    fish.See();
            //    fish.Swim();
            //}
            #endregion
            #region Sealed
            //Developer developer = new Developer();
            //developer.Knowledge();

            //Backend backend = new Backend();
            //backend.Knowledge();
            #endregion
            #region Interface
            //Calculate calculate = new Calculate();
            //Console.WriteLine(calculate.Sum(3, 4)); ;
            //Studen redableStuden = new Studen();

            //IRead read = redableStuden;
            //ISum sum = redableStuden;           
            //redableStuden.Read();
            #endregion

            #region static

            //Person person = new Person();
            //person.Group = 20;
            //Person.Name = "Test";
            //Person person1 = new Person();
            //Console.WriteLine(Person.Name);
            //Console.WriteLine(person.Group);
            //Console.WriteLine(person1.Group);
            //Console.WriteLine(Person.Name);\
            //Person.Name = "Hakim";
            //Person person = new Person();
            //Console.WriteLine(Person.GetName()); ;
            //Person person = new Person();
            //Console.WriteLine($"Id1 {person.Id}");
            //Console.WriteLine(Person.count);
            //Person  person1 = new Person();
            //Console.WriteLine($"Id2 {person1.Id}");
            //Console.WriteLine(Person.count);
            //Person person2 = new Person();
            //Console.WriteLine($"Id3 {person2.Id}");
            //Console.WriteLine(Person.count);
            //Console.WriteLine(Person.count);
            //Person person1 = new Person();
            //Person person2 = new Person();
            //Person person3 = new Person();
            Student.Name = "Eli";
            Console.WriteLine(Student.Name);
            string a = "Eli";
            a.Reverse();
            #endregion




        }
    }
    #region Abstract class

    //abstract class Animal
    //{

    // public abstract  void Eat();
    //    public  virtual void See()
    //    {
    //        Console.WriteLine("See as Animal");
    //    }
    //    public int Type { get; set; }
    //}
    //abstract class Fish:Animal
    //{
    //    public  abstract void Swim();
    //    public override void See()
    //    {
    //        Console.WriteLine("See As Fish");
    //    }
    //}

    //abstract class Bird:Animal
    //{
    // public abstract void Fly();
    //}
    // class Eagle : Bird
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as Eagle");
    //    }
    //    public override void Fly()
    //    {
    //        Eat();
    //        Console.WriteLine("Fly as Eagle");
    //    }

    //    public override  void See()
    //    {
    //        Console.WriteLine("See as Eagle");

    //    }



    //}
    //class Shark : Fish
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as shark");
    //    }

    //    public override void Swim()
    //    {
    //        Console.WriteLine("Swim as Shark");
    //    }
    //    public  override void See()
    //    {
    //        Console.WriteLine("See as Shark");
    //    }
    //}

    //class GoldFish : Fish
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as GoldFish");
    //    }

    //    public override void Swim()
    //    {
    //        Console.WriteLine("Swim as GoldFish");
    //    }
    //}
    #endregion

    #region Interface
    //abstract class BaseArithmetich
    //{
    //    public virtual int Sum(int num1, int num2)
    //    {
    //        return num1 + num2;
    //    }
    //    public virtual int Difference(int num1, int num2)
    //    {
    //        return num1 - num2;
    //    }
    //    public virtual int Multiply(int num1, int num2)
    //    {
    //        return num1 * num2;
    //    }
    //    public virtual double Divided(double num1, double num2)
    //    {
    //        return num1 / num2;
    //    }
    //}

    //interface ISum
    //{
    //    int Sum(int num1, int num2);
    //}
    //interface IDifference
    //{
    //    int Difference(int num1, int num2);
    //}
    //interface IDivided
    //{
    //    double Divided(double num1, double num2);
    //}
    //interface IMultiply
    //{
    //    double Multiply(double num1, double num2);
    //}
    //interface IRead
    //{
    //    public string Read()
    //    {
    //        return "Read";
    //    }
    //}
    //class Calculate : ISum, IDifference, IDivided, IMultiply
    //{
    //    public int Difference(int num1, int num2)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public double Divided(double num1, double num2)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public double Multiply(double num1, double num2)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Sum(int num1, int num2)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //abstract class Person
    //{
    //    public int Name { get; set; }
    //}
    //class Studen : Person, ISum, IDifference, IRead,IMultiply
    //{
    //    public int Difference(int num1, int num2)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public double Multiply(double num1, double num2)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public  int Sum(int num1, int num2)
    //    {
    //        return num1 + num2;
    //    }
    //}
    #endregion
    #region Sealed
    //abstract  class Person
    //  {
    //      public abstract void Eat();
    //  }
    //  class Student:Person
    //  {
    //      public override void Eat()
    //      {
    //          Console.WriteLine("Eat As Student");
    //      }

    //      public virtual void Knowledge()
    //      {
    //          Console.WriteLine("Riyaziyyat");
    //      }
    //  }
    //sealed  class Developer : Student
    //  {

    //      public sealed  override void Knowledge()
    //      {
    //          Console.WriteLine("C#,js,HTML,CSS");
    //      }
    //      public  override void Eat()
    //      {
    //          throw new NotImplementedException();
    //      }
    //  }

    //  class Backend:Developer
    //  {
    //  }
    //  class Frontend:Developer
    //  {

    //  }
    #endregion


    #region Static
    class Person {
        //static Person()
        //{
        //    count++;
        //}

        public int Id;
        public  string Name;
        public int Group;
        public static int count;
        
        //public static  string GetName()
        //{
        //    return Name;
        //}
    }
    static class Student
    {
        static Student()
        {
            Console.WriteLine("Student Created");
        }
        public static string Name { get; set; }
    }
    #endregion
}