using System.Diagnostics.Contracts;

namespace Polimorophism_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Class,Abstract Method
            //Animal animal = new Animal();
            //Bird bird = new Bird(); 
            Animal eagle = new Eagle();
            //eagle.Fly();
            //eagle.Eat();
            //eagle.See();

            Animal shark = new Shark();
            //shark.Swim();
            //shark.Eat();
            //shark.See();

            Animal[] animals = new Animal[] { eagle, shark };
            foreach (var animal in animals)
            {
                animal.Eat();
                animal.See();
            }



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
        }
    }

    abstract class Animal
    {
       
     public abstract  void Eat();
        public  virtual void See()
        {
            Console.WriteLine("See as Animal");
        }
        public int Type { get; set; }
    }
    abstract class Fish:Animal
    {
        public  abstract void Swim();
    }
    abstract class Bird:Animal
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
            Eat();
            Console.WriteLine("Fly as Eagle");
        }

        public override  void See()
        {
            Console.WriteLine("See as Eagle");
          
        }


       
    }
    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
        public  override void See()
        {
            Console.WriteLine("See as Shark");
        }
    }

    class GoldFish : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as GoldFish");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as GoldFish");
        }
    }

}