using Exception_Reflection.Utilities.Exceptions;
using System.Xml.Linq;

namespace Exception_Reflection
{
    internal class Program
    {
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
            #endregion
            string name=Console.ReadLine();

            string[] Array = new string[4];
            

            try
            {
                AddToArray(Array, name);
            }
            catch (Exception Exc) 
            {

                Console.WriteLine(Exc.Message);
            }
        }

         static void AddToArray(string[] array,string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]))
                {
                    throw new MyException("Wrong name");
                }
                    

            }
                Console.WriteLine("true name");

        }



    }
}