using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace JudaFirstProject
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                return;
            }

            string Path = args[0];

            if (!Directory.Exists(Path))
            {
                return;
            }

            string[] directories = Directory.GetDirectories(Path);
            List<string> directoriesToDelete = GetFoldersToDelete(directories);

            if (directoriesToDelete.Count == 0)
            {
                return;
            }

            Console.WriteLine("The following diriectories has been found");
            Console.WriteLine("__________________________________________");

            for (int i = 0; i < directoriesToDelete.Count; i++)
            {
                Console.WriteLine(directoriesToDelete[i]);
            }
            Console.WriteLine("Do you want to delete?");

            var answer = Console.ReadLine();
            if (answer == "Y" || answer == "y" || answer == "YES" || answer == "Yes" || answer == "YeS")
            {
                //לולאות או לא להיות
                for (int i = 0; i < directoriesToDelete.Count; i++)
                {
                    Directory.Delete(directoriesToDelete[i], true);
                }
            }
        }

        private static List<string> GetFoldersToDelete(string[] directories)
        {
            List<string> directoriesToDelete = new List<string>();

            foreach (string directory in directories)
            {
                if (DoesHaveOnllySubtitleFiles(directory))
                {
                    directoriesToDelete.Add(directory);
                }
            }

            return directoriesToDelete;
        }

        static string[] subExtensions = new string[]
        {
            "sub",
            "srt",
            "sbv"
        };


        private static bool DoesHaveOnllySubtitleFiles(string directory)
        {
            string[] allFiles = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);

            int subtitleFileAmount = 0;
            foreach (string extension in subExtensions)
            {
                string[] subFiles = Directory.GetFiles(directory, "*." + extension, SearchOption.AllDirectories);
                subtitleFileAmount += subFiles.Length;
            }

            return allFiles.Length == subtitleFileAmount;
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
