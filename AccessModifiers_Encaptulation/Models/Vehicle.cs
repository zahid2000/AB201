namespace AccessModifiers_Encaptulation.Models;

public class Vehicle
{
    internal string Brand;
    public string Model;
    public double Price;
    protected string _color;
    private double _engine;
    public Vehicle()
    {
        _engine = 0;
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
