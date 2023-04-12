namespace AccessModifiers_Encaptulation.Models;

public class Vehicle
{
    internal string Brand;
    public string Model;
    public double Price;
    protected string _color;
    public double _engine;
  
    public Vehicle(double engine)
    {
        _engine=engine;
    }
    public void Run()
    {
        _engine = 6;
        Brand = "Mercedes";
        Console.WriteLine("Run as a vehicle");
    }

    //protected class Car
    //{

    //}
    //private class Car
    //{

    //}
}
