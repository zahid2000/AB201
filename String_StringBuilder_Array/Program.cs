
//string name = "Esli";

//string name2 = name;
//name2 = "Cosqun";

//string name3 = "Hikmet";
//name = name3;
//using System.Linq.Expressions;
//using System.Text;

//string name = "Eli";


//string name4 = "Esli";

//if (name4.Length>3)
//{
//    Console.WriteLine(name4);
//}

//Console.WriteLine(name2 );
//eli ->ile

//Console.WriteLine(Reverse("hjvghvghvfcxg"));
//string Reverse(string str)
//{
//    string result = "";
//    for (int i = str.Length - 1; i >= 0; i--)
//    {
//        result += str[i];
//    }
//    return result;       
//}

//string ReverseWithBuilder(string str)
//{
//    StringBuilder result = new StringBuilder();
//    for (int i = str.Length - 1; i >= 0; i--)
//    {
//        result.Append(str[i]);

//    }
//    return result.ToString();
//}

//string test = "       Eli     ";


//Console.WriteLine(test.Trim());
//Console.WriteLine(test.Replace('i', 'a'));
//bool StartWith(string str,char checkValue)
//{
//    return str[0] == checkValue;
//}
//int[] arr = { 1, 2, 3, 4, 5 };
//Console.WriteLine("Nece eded daxil edeceksen?Sayi daxil et:");
//int count = int.Parse(Console.ReadLine());
//Student[] students = new Student[count];
//Console.WriteLine("Hello");
//Student st= new Student()
//immutable

//string name1 = "Eli";
//string name2 = name1;
//name1 = "Eli2";
//string name3 = "Eli";
//string name5 = "Eli";
//String name4 = new String("Eli");
////Console.WriteLine(name3==name4);
////Console.WriteLine(ReferenceEquals(name4, name3));
//Student stu = new Student { Name = "Muslum" };
//Student stu1 = new Student { Name = "Muslum" };
//Console.WriteLine(stu.Name==stu1.Name);
//class Student 
//{
//    public Student()
//    {

//    }
//    public string Name { get; set; }
//    string GetName()
//    {
//        return Name;
//    }
//}

//class Person
//{
//}
using String_StringBuilder_Array;
using System.Collections.Immutable;
using System.Globalization;
using System.Text.RegularExpressions;

string name = "1Hello Worldo salam dunya Ab201";
//Console.WriteLine(name);
//Console.WriteLine(name.EndsWith("Hello"));
//Console.WriteLine(name.Contains("o"));

//Console.WriteLine(name.IndexOf('o', name.IndexOf('o', name.IndexOf('o') + 1)+1));
//Console.WriteLine(name.LastIndexOf('o'));

//Console.WriteLine(name.Replace("Hello","Salam"));
//Console.WriteLine(name.Remove(name.IndexOf('o'),2));
//Console.WriteLine(name.Substring(,4));

//Console.WriteLine(name.Length);
//Console.WriteLine(name.Trim().Length);
//string[] arr = name.Split(' ');

//foreach (string s in arr)
//{
//    Console.WriteLine(s);
//}

//string[] nums = { "salam","Hello","World"};
//Console.WriteLine(string.Join('-',nums,1,2));

//Console.WriteLine(string.Compare("abc","c"));
//string name10 = " ";
//if (string.IsNullOrEmpty(name10.Trim()))
//{
//    Console.WriteLine("IsnullOr Empty");

//}
//else
//{
//    Console.WriteLine(true);
//}
//Console.WriteLine(name.ToLower());
//Console.WriteLine(name.ToUpper());


//string test = "Hakim";
//string check=Console.ReadLine();
//if (check.ToLower() == test.ToLower())
//{
//    Console.WriteLine("var");
//}
//else
//{
//    Console.WriteLine("Yoxdur");
//}

//1,2,3,
//4,5,6
#region Array

//1,2,3,4,5,6,7,8,9,10
//int[,,] arr = { { { 1,2 },{ 3,4} },
//    { { 5,6},{7,8 } } };
//Console.WriteLine(arr[0, 1, 1]);
//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}
//Array.Resize(ref arr, arr.Length + 5);
//Resize(ref arr, arr.Length + 5);
//int num1 = 5;
//int num2 = 10;
//num1 = num2;
//void Resize(ref int[] arr,int length)
//{
//    int[] ints = new int[length];
//	for (int i = 0; i < arr.Length; i++)
//	{
//		ints[i] = arr[i];
//	}
//	arr= ints;
//}


//int[] arr = { 3, 1, 2, 5, 4, 15, 8 };
//////var newArr = arr.Clone();
//////Console.WriteLine(ReferenceEquals(newArr,arr));

//int[] newArr = new int[arr.Length + 5];
//arr.CopyTo(newArr, 3);

//foreach (var item in (int[])newArr)
//{
//    Console.WriteLine(item);
//}

//var newArr=arr.Reverse();
//Console.WriteLine("Nizamsiz");
//foreach (int i in newArr)
//{
//    Console.WriteLine(i);
//}

//Array.Sort(arr);
// newArr = arr.Reverse();
//Console.WriteLine("Nizamli");
//foreach (int i in newArr)
//{
//    Console.WriteLine(i);
//}

#endregion

#region Regex
string pattern = @"^\+[1-9]{1,3}[1-9]{1}[0-9]{1}[1-9]{1}[0-9]{6}$";
string pattern2 = @"\d";
//Regex regex = new Regex(pattern);
////Console.WriteLine("Object method "+regex.IsMatch("+99470569637345"));
//Console.WriteLine(Regex.IsMatch("+994705696373",pattern));
//Regex regex= new Regex(pattern2);
//string result = regex.Replace("+994705696373 jnhjbvhgvj njknknkjnbkjy7698 nhjkb989089nn,ui7y978y", "*");
////Console.WriteLine(result);
//string inp = "+994705696373 jnhjbvhgvj njknknkjnbkjy7698 nhjkb989089nn,ui7y978y";
//Console.WriteLine(Regex.Replace(inp, pattern2, "$")); ;
//string pattern3 = @"[,_-]";
//string inp = "Hikmet Muslum Melek,Eli_Hakim-Shahin";
////Regex regexSplit=new Regex(pattern3);
////string[] result = regexSplit.Split(inp);




//string[] result = Regex.Split(inp,pattern3);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


#endregion


#region Tuple
//Person person=new Person()
//{
//    Name="Murad",
//    Surname="Mecidov",
//    Age=21
//};

//var info = person.GetInfo();
//Console.WriteLine(info.Item2);
//Console.WriteLine(info.Surname);
//Console.WriteLine(info.Age);
#endregion
