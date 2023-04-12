namespace AccessModifiers_Encaptulation.Records;

public class MyClass
{
    public string Name { get; set; } = "Test1";
    public override string ToString()
    {
        return "Hello World";
    }
}
public record MyRecord
{
    public MyRecord(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public string Name { get; init; }
    public string Surname { get; init; }
    public int Age { get; init; }
}   

//shorthand declare
public record ShortRecord(string Name,string Surname,int age);
