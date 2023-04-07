
//string name = "Esli";

//string name2 = name;
//name2 = "Cosqun";

//string name3 = "Hikmet";
//name = name3;
using System.Linq.Expressions;
using System.Text;

string name = "Eli";


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

string test = "       Eli     ";


Console.WriteLine(test.Trim());

Console.WriteLine(test.Replace('i', 'a'));
bool StartWith(string str,char checkValue)
{
    return str[0] == checkValue;
}

