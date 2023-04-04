

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


Console.WriteLine(FullName("Hakim", 10));

string FullName(string name, int age)
{
    if (age > 15)
    {
        return name + age;
    }
    return "age < 15";
}

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
