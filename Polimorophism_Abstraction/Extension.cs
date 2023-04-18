using System.Text;

namespace Polimorophism_Abstraction;

public static class Extension
{
    public static int Pow(this int num, int power)
    {
        int result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= num;
        }
        return result;
    }
    public static int Pow(this int num)
        {
        return num * num;
    }
    public static string MyReverse(this string str)
    {

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            stringBuilder.Append(str[i]);
        }
        return stringBuilder.ToString();
    }

    public static Test WriteHello(this Test test,int num) {

        return test;
    }

}
