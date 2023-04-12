using AccessModifiers_Encaptulation.Models;
using AccessModifiers_Encaptulation.Records;
using Test2;


#region Public,internal(class,interface)-- class and all class's members
//Vehicle vehicle = new Vehicle();
//vehicle.Run();
//vehicle.Brand = "BMW";
//vehicle.Price = 100;
//Console.WriteLine(vehicle.Brand);
#endregion

#region Protected,Private --All class's members
//Vehicle vehicle=new Vehicle();
//vehicle._engine = 1.6;
//var prop = vehicle.GetType().GetField("_engine", System.Reflection.BindingFlags.NonPublic
//    | System.Reflection.BindingFlags.Instance);
//prop.SetValue(vehicle, 1.6);
//var _engine=prop.GetValue(vehicle);
//Console.WriteLine(_engine);
#endregion


#region Encaptulation
//Car car=new Car();
//car.SetSpeed(300);

//double speed=car.GetSpeed();
////Console.WriteLine(speed);
//car.Speed = -20;
//Console.WriteLine(car.ProductYear);
//Car car1 = new Car(5);

//Vehicle vehicle = new Vehicle(2.6);
////Person person = new Person();
//Student student = new Student();
#endregion
#region Private Protected,Protected Internal
//Person person = new Person();
//person.Name = "Eli";
//Student student = new Student();
//student.Name = "Hikmet";
#endregion
#region Readonly
//Person person = new Person("Hikmet", "Tagizade");
//Console.WriteLine(person.Name);
#endregion


namespace AccessModifiers_Encaptulation;
class Program
{
    public static void Main(string[] args)
    {


        #region Record
        //MyClass myClass = new MyClass() {
        //    Name = "Eli"
        //};
        //myClass.Name = "Test";
        //MyClass myClass1 = myClass;
        //myClass1.Name = "Hikmet";
        //Console.WriteLine(myClass.Name);
        //Console.WriteLine(ReferenceEquals(myClass,myClass1));
        //MyRecord record = new MyRecord() {
        //    Name="Murad",
        //    Surname="Tagizade",
        //    Age=21
        //};
        //MyRecord record2 = record with { Name = "Esli" ,Surname="Namazova"};
        ////record.Name = "Melek";
        //MyRecord record3 = record2 with { Name = "Melek" };
        //Console.WriteLine(record);
        //Console.WriteLine(record2);
        //Console.WriteLine(record3);
        //Console.WriteLine(ReferenceEquals(record,record2));
        ShortRecord record = new ShortRecord("Eli", "Tagizade", 21);
        ShortRecord record1 = record with { Name = "Melek" };

        Console.WriteLine(record);
        Console.WriteLine(record1);
        #endregion
    }
}