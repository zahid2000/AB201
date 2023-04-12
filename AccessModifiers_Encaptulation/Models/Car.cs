using System.Reflection;

namespace AccessModifiers_Encaptulation.Models;

internal class Car:Vehicle
{
    
    private double _speed;
    private int _ProductYear;

    public Car(double engine) : base(engine)
    {
    }

    public int ProductYear { get; } = 40;
   
    public double Speed { 
        get {

            if (_speed>=20)
            {
                return _speed;
            }
            return -1;
        } 
        set
        {
            if (value>=20)
            {
                _speed = value;
                return;
            }
            Console.WriteLine( "Wrong Speed" );
        }
         }
    //public void SetSpeed(double value)
    //{
    //    if (value>20) { 
    //    _speed = value;
    //        return;
    //    }
    //    Console.WriteLine("Wrong value");
    
    //}
    //public double GetSpeed()
    //{
    //    return _speed;
    //}
    //public void Start()
    //{
    //    Brand = "BMW";
    //    Model = "X6";
    //    Run();
    //}
}
