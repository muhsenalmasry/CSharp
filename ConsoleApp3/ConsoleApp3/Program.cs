using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "c:/users/muhsen/temp/test.txt";
            var content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
    }
}
