using System;

class Program
{
    public static void Main()
    {

        Console.WriteLine(ReverseString("Emil Yusif Tural Nurlan Faiq"));
    }

    static string ReverseString(string name)
    {

        {
            string reverseName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseName += name[i];

            }
            return reverseName;
        }

    }

}