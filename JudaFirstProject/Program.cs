using System;
using System.IO;

namespace JudaFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllLines("C:\\Users\\Haludi\\OneDrive\\Documents\\stam.txt")
        }
    }

    class StringExtension
    {
        public static void Print(string str)
        {
            foreach (char ch in str)
            {
                Console.Write(ch);
            }

        }

        public static void PrintRevers(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[str.Length - i - 1];
                Console.Write(ch);
            }
        }

        //"Juda"
        public static string Revers(string str)
        {
            string ret = "";

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[str.Length - i - 1];
                ret = ret + ch;
            }

            return ret;
        }

    }
}
