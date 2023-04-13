namespace String_StringBuilder_Array;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public (string Surname,string Age, string Name) GetInfo()
    {        
        return (Surname,Age.ToString(), Name);
    }
    public string GetSurname()
    {
        return Surname;
    }
}
