using System;

namespace JudaFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class StringExtension
    {
        public static void Revers(string str)
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
    }
}
