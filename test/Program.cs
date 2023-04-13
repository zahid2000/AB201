namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4, 8));
        }

      static  int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
   abstract class Animal
    {
      public  abstract void Eat();
    }

abstract  class Bird : Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }


}