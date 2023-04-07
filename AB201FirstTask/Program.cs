

#region Variables
//string name = "Hikmət";
//var a = 5;

//dynamic b;
//b = 5;
//Console.WriteLine(b);
//b = true;
//Console.WriteLine(b);


#endregion
#region Conditions
//int age = 17;
//if (age>16)
//{
//    Console.WriteLine("Age >16");
//}
//else if (age == 16)
//{
//    Console.WriteLine("Age == 16");
//}
//else
//{
//    Console.WriteLine("Age < 16");
//}


//int day = 4;

//switch (day)
//{

//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Weekend");
//        break;
//    default:
//        Console.WriteLine("Wrong number");
//        break;
//}



//int month= 3;
//string name = "Hikmet";
//switch (name)
//{
//    case "Hikmet" when name.Length > 5:
//        switch (name)
//        {
//            case "Hikmet":
//                Console.WriteLine("Test");
//                break;
//            default:
//                break;
//        }
//        break;
//    case "Hikmet" when name.Length==5:
//        Console.WriteLine("Ok");
//        break;

//}

#endregion
#region Loops
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//infinite loop->for
//for (; ; )
//{
//    Console.WriteLine(5);
//}
//for (int i=0; true;i++)
//{
//    Console.WriteLine("Hello");
//}
//int i = 0;
//while (i < 10)
//{

//    i++;
//    if (i != 2)
//    {
//        Console.WriteLine(i);
//    }
//}

//int num = 5;
//do
//{
//   Console.WriteLine(num);

//} while (num>5);



//int[] arr = { 1, 2, 3, 12, 14, 15 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//foreach (int item in arr)
//{
//    if (item % 2 == 0)
//    {
//        Console.WriteLine(item);
//    }
//}

//for (int i = 10; i >= 0; i--)
//{

//}

#endregion


#region Methods
//void Print(int num)
//{
//    Console.WriteLine(num);
//}

//int num1 = 5;
//int num2 = 6;
////Console.WriteLine(Sum(num1, num2));
////Console.WriteLine(Difference(num1, num2));
//int result = Difference(num1, num2);
//Print(result);
//int Sum(int num1, int num2)
//{
//    return num1 + num2;
//}
//int Difference(int num1, int num2)
//{
//    return num1 - num2;
//}

//string productName = "Iphone15";
//double productPrice = 12000.99;
//string prouctBrand = "Apple";
//string productName1 = "Galaxy note 10";
//double productPrice1 = 1000.99;
//string prouctBrand1 = "Samsung";
//PrintProductInfo(productName, Discount(productPrice, 0), prouctBrand);
//PrintProductInfo(productName1, Discount(productPrice1, 50), prouctBrand1);
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//PrintProductInfo(productName, productPrice, prouctBrand);
//PrintProductInfo(productName1, productPrice1, prouctBrand1);
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//PrintProductInfo(productName, productPrice, prouctBrand);
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//PrintProductInfo(productName, Discount(productPrice,40), prouctBrand);

//void PrintProductInfo(string productName,double productPrice,string ProductBrand)
//{
//    Console.WriteLine(productName + " " + productPrice + " " + prouctBrand);
//}
//double Discount(double price,int discount)
//{
//    return price - price * discount / 100;
//}


//Console.WriteLine(FullName("Hakim", 10));

//string FullName(string name, int age)
//{
//    if (age > 15)
//    {
//        return name + age;
//    }
//    return "age < 15";
//}

//Console.WriteLine(FullName("Hakim", 20));

//string name = "Hakim";
//int age = 20;

//Console.WriteLine("{0} {1}", name, age);
//Console.WriteLine($"{name} {age}");
//Console.WriteLine(name + " " + age);

//Print(16);
//void Print(int age)
//{
//    if (age < 15)
//    {
//        Console.WriteLine("Age < 15");
//        return;
//    }
//    Console.WriteLine(age);
//}


#endregion


#region Value & Reference types

////int num1 = 5;

////int num2 = num1;
////num1 = 10;

////Console.WriteLine($"num1={num1}");
////Console.WriteLine($"num2={num2}");

////int[] nums1 = { 1, 2, 3, 5, 6, 7 };
////nums1[0] = 10;
////int[] nums2 = nums1;

////int[] nums3 = { 1, 2, 3, 4, 5, 6 };
////Console.WriteLine(nums1[0]);
////Console.WriteLine(nums2[0]);
////Console.WriteLine(nums3[0]);

////nums2[0] = 20;

////Console.WriteLine(nums1[0]);
////Console.WriteLine(nums2[0]);
////Console.WriteLine(nums3[0]);


////int num1 = 5;
////Console.WriteLine(num1);
////ChangeNum(num1);
////Console.WriteLine("Outside " + num1);

////void ChangeNum(int num)
////{
////    num = 200;
////    Console.WriteLine("Method " + num);
////}



////int[] nums = { 5, 1, 5, 12 };//101
////Console.WriteLine(nums[0]);
////ChangeArray(nums);
////Console.WriteLine(nums[0]);//101

////void ChangeArray(int[] arr)//101
////{
////    arr[0] = 100;
////    Console.WriteLine(arr[0]);
////}

////string FullName = Concat(fin:"1bhjghhg",name:"Eli");
////Console.WriteLine(FullName);
////string Concat(string name,string surname="hiu",string fin = "SSS")
////{
////    return name + " " + surname+" "+fin;
////}
////Console.WriteLine("Arrayin uzunlugunu daxil et");
////int size=int.Parse(Console.ReadLine());

////string numStr = "10";
////int[] arr = new int[size];
////for (int i = 0; i < arr.Length; i++)
////{
////    Console.WriteLine($"{i+1}-ci Ededi daxil et:");
////    arr[i] = int.Parse(Console.ReadLine());
////}
////Console.WriteLine("Netice");
////PrintArrayElement("Eli", 15, 2, 3, 4, 5, 6);
////int[] arr = { 1, 2, 3, };
////PrintArrayElement(1, 2, 3, 4, 17, 26 );

////void PrintArrayElement(string name,int age,params int[] arr)
////{
////	foreach (int num in arr)
////	{
////        Console.WriteLine(num);
////    }
////}
////int num = 1;
////test(num);
////Console.WriteLine(num);

////void test(int num)
////{
////    num = 15;
////    Console.WriteLine(num);
////}

////int[] arr = { 1, 2, 4, 5, 6, 7, };
////Console.WriteLine(arr[0]);
////test2(arr);
////Console.WriteLine(arr[0]);

////void test2(int[] arr)
////{
////    arr[0] = 15;
////    Console.WriteLine(arr[0]);
////}



//using System;
//using System.Threading.Channels;

//namespace AB201FirstTask
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            //int num1 = int.Parse(Console.ReadLine());
//            //int num2 = 10;
//            //Console.WriteLine(num2 / num1);



//            Print("Hikmet");
//        }






//        //static void Print(params string[] arr)
//        //{
//        //    Console.WriteLine("Params Method");
//        //}
//        //static void Print(string str)
//        //{
//        //    Console.WriteLine("Sade Method");
//        //}

//        //static void Print(string str1, string str2 = "test")
//        //{
//        //    Console.WriteLine("default Method");
//        //}



//        // static void Print(string str)
//        // {
//        //     Console.WriteLine(str);
//        // }
//        //static void Print(string str1,string str2,int years)
//        // {
//        //     Console.WriteLine(str1+" "+str2+" ");
//        // }
//        // static void Print(string str1, int str2,int age)
//        // {
//        //     Console.WriteLine(str1 + " " + str2+" "+age);
//        // }


//    }
//}

#endregion

#region Ref,Out


//int num;
//SetNumber(out num);
//Console.WriteLine(num);



//void SetNumber(ref int num)
//{
//    num = 10;
//    Console.WriteLine(num);
//}

#endregion

#region Recursive Method-> Factorial

//int result = GetFactorial(6);
//Console.WriteLine(result);
////(6*5*4*3*2*1)
//int GetFactorial(int num)
//{
//    if (num <= 1)
//    {
//        return 1;
//    }
//    int result1 = num * GetFactorial(num - 1);
//    return result;
//}
#endregion