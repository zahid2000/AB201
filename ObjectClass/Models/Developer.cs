namespace ObjectClass.Models;

internal class Developer:Person
{
    public Developer()
    {
        Console.WriteLine("Developer created");
    }
    public Developer(string name):base(name){}
}
