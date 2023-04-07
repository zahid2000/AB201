namespace ObjectClass.Models;

internal class Person
{
    public Person()
    {
        Console.WriteLine("Person created");
    }
    public Person(string name) : this()
    {
        if (name.Length>5)
        {
            this.name = name;
        }
    }
    public Person(string name, string surname) : this(name)
    {
        this.surname = surname;
    }
    public Person(string name, string surname, int age) : this(name, surname)
    {
        this.age = age;
    }
    public string name;
    public string surname;
    public int age;
    public void ShowInfo()
    {
        Console.WriteLine($"{name} {surname} {this.age}");
    }
}
