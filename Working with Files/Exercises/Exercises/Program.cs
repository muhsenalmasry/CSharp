using System;
using System.IO;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText(@"C:\Users\Muhsen\Desktop\hello world.txt");
            var words = file.Split(' ');

            var longestWord = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (longestWord.Length < words[i].Length)
                {
                    longestWord = words[i];
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
