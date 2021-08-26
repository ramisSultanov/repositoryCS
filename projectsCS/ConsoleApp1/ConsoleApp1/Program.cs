using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static string BreakC(string str)
        {
            char[] charArray = str.ToCharArray();

            List<string> list = new List<string>();
            list.Add(Convert.ToString(charArray[0]));

            for (int i = 1; i < charArray.Length; i++)
            {
                if (Convert.ToString(charArray[i]) == Convert.ToString(charArray[i]).ToUpper())
                {
                    list.Add(" ");
                }
                list.Add(Convert.ToString(charArray[i]));
            }
            str = string.Join("", list.ToArray());
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BreakC("camelCasing"));

        }
    }

}