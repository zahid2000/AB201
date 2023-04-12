namespace AccessModifiers_Encaptulation.Models;

public class Person
{
    public readonly string Surname = "Eliyev";
    public Person(string name, string surname)
    {
        Surname = surname;
        Name = name;
    }
    public Person()
    {
        
    }
    protected internal string Name { get; init; } = "Eli";
    private int age { get; set; }
    

    //public void test()
    //{
    //    Surname = "nhgj";
    //}

}
