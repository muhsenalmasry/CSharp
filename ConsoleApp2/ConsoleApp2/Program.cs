using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:/users/muhsen/desktop/newFile.txt";
            File.WriteAllText(path, "something comes here");
            Console.WriteLine(File.ReadAllText(path));

            Console.WriteLine();
            
        }
        
    }
}
