using Exception_Reflection.Models;
using System.Reflection;

namespace Exception_Reflection
{
    
    internal class Program
    {
        int a = 5;
        static void Main(string[] args)
        {
            #region Exception
            //        //int num1 = int.Parse(Console.ReadLine());
            //        //int num2 = int.Parse(Console.ReadLine());
            //        //if (num2 == 0)
            //        //{
            //        //    Console.WriteLine("hjggjh");
            //        //}
            //        //else
            //        //{

            //        //    Console.WriteLine(num1 / num2);
            //        //}

            //    //Start:
            //    //    try
            //    //    {
            //    //        //int[] arr = new int[10];
            //    //        ////arr[11] = 5;
            //    //        Console.WriteLine("Birinci ededi daxil et:");
            //    //        int num1 = int.Parse(Console.ReadLine());
            //    //        Console.WriteLine("Ikinci ededi daxil et:");
            //    //        int num2 = int.Parse(Console.ReadLine());

            //    //        Console.WriteLine(num1 / num2);
            //    //    }

            //    //    catch (DivideByZeroException)
            //    //    {
            //    //        Console.WriteLine("Davam etmek istiyirsen?y/n");
            //    //        string key=Console.ReadLine();  
            //    //        if (key.ToLower() =="y")
            //    //        {
            //    //            goto Start;

            //    //        }
            //    //        Console.WriteLine("0 daxil etmek olmaz");
            //    //    }
            //    //    catch (FormatException)
            //    //    /*{*/
            //    //        Console.WriteLine("Format sehvdir");
            //    //    }
            //    //    catch (Exception ex)
            //    //    {

            //    //        Console.WriteLine(ex.Message);
            //    //        //int num3 = int.Parse("cdsd");
            //    //    }


            //    //    finally
            //    //    {
            //    //        Console.WriteLine("Hello AB201");
            //    //    }


            //    //    //string[] names = new string[] { "Eli" };
            //    //    //AddNameToArray(names, "hikmet");

            //    //}

            //    //public static void AddNameToArray(string[] arr,string name)
            //    //{
            //    //    if (char.IsUpper(name[0]))
            //    //    {
            //    //        Array.Resize(ref arr, arr.Length+1);
            //    //        arr[arr.Length-1]=name;
            //    //        return;
            //    //    }
            //    //    throw new Exception("Name is not valid");
            //    //} 
            //    string name=Console.ReadLine();

            //    string[] Array = new string[4];


            //    try
            //    {
            //        AddToArray(Array, name);
            //    }
            //    catch (Exception Exc) 
            //    {

            //        Console.WriteLine(Exc.Message);
            //    }
            //}

            // static void AddToArray(string[] array,string name)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        if (char.IsDigit(name[i]))
            //        {
            //            throw new MyException("Wrong name");
            //        }


            //    }
            //        Console.WriteLine("true name");

            //}

            //Person person = new Person();
            ////person.GetException();
            //Person.GetException();
            #endregion
            #region Reflection
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Type[] types=assembly.GetTypes();
            //foreach (Type   type in types)
            //{
            //    //Console.WriteLine($"{type.Namespace}->{type.Name}");
            //    Console.WriteLine(type.FullName);
            //    //PropertyInfo[] props=type.GetProperties();
            //    //foreach (PropertyInfo prop in props)
            //    //{
            //    //    Console.WriteLine(prop.Name);
            //    //}
            //    //MethodInfo[] methods=type.GetMethods();
            //    //foreach (MethodInfo method in methods)
            //    //{
            //    //    Console.WriteLine(method.Name);
            //    //
            //    //var fields=type.GetFields(BindingFlags.Static|BindingFlags.NonPublic);
            //    //foreach (FieldInfo field in fields)
            //    //{
            //    //    Console.WriteLine(field.Name);
            //    //}
            //    Console.WriteLine("============================================");
            //}

            //Type type = Type.GetType("Exception_Reflection.Models.Person");

            //Person person = new Person();
            //Type type=person.GetType();
            Type type = typeof(Person);


            //PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic );
            //foreach (PropertyInfo property in properties)
            //{
            //    Console.WriteLine(property.Name);
            //}

            //object created
            //Person person = new Person();
            Person person = (Person)Activator.CreateInstance(typeof(Person));
            //Person person = (Person)Assembly.GetExecutingAssembly().CreateInstance(typeof(Person).ToString());
            //PropertyInfo propId = type.GetProperty("Id", BindingFlags.Instance | BindingFlags.NonPublic );
            //PropertyInfo propName = type.GetProperty("Name", BindingFlags.Instance | BindingFlags.Public);
            //Console.WriteLine(propId.Name);
            //propId.SetValue(person, 5);
            //propName.SetValue(person, "Hakim");
            //Console.WriteLine(propId.GetValue(person));
            //Console.WriteLine(propName.GetValue(person));
            //PropertyInfo propCount= type.GetProperty("Count");
            //propCount.SetValue(null, 25);
            //Console.WriteLine(propCount.GetValue(null));
            //PropertyInfo propName = type.GetProperty("Name");
            //PropertyInfo propSurname = type.GetProperty("Surname");
            //propName.SetValue(person, "Murad");
            //propSurname.SetValue(person, "Eliyev");
            //MethodInfo methodGet = type.GetMethod("GetFullName");
            //methodGet.Invoke(person, null);

            MethodInfo methodGet = type.GetMethod("GetMessage");
            methodGet.Invoke(person,new object[] { "Salam AB201",5});
            #endregion

        }
    }

     class Test
    {
       public static int abh;
    }
     class Test1:Test
    {

    }
}