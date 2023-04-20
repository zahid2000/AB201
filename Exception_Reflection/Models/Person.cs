using Exception_Reflection.Utilities.Exceptions;

namespace Exception_Reflection.Models;

public class Person
{
    public Person()
    {
        
    }
    private int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public static int Count { get; set; }
    private string _fatherName { get; set; }
    public string _school;
    public static void GetException()
    {
        throw new InvalidNameException("Name is wrong");
    }
    public void GetFullName()
    {
        Console.WriteLine(Name+" "+Surname);
    }
    public void GetMessage(string message,int number)
    {
        Console.WriteLine(message+" "+number);
    }
}

public class Student : Person
{
    public int Grooup { get; set; }
    private static string _name;
}