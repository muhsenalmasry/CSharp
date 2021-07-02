using System;
using System.IO;

namespace TiedostoHaku
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(args[0]);
            if(args.Length == 1)
            {
                AllFiles(dir);
            }
            if(args.Length == 2)
            {
                FilesOfType(dir, args[1]);
            }
            if(args.Length == 3)
            {
                SearchForContent(dir, args[1], args[2]);
            }
            
        }

        static void AllFiles(DirectoryInfo dir)
        {
            foreach (var file in dir.GetFiles())
            {
                Console.WriteLine(file.Name + ", " + file.Length +" bytes, " + file.CreationTime);
            }
            var subdirectories = dir.GetDirectories();
            foreach (var subdirectory in subdirectories)
                AllFiles(subdirectory);
        }

        static void FilesOfType(DirectoryInfo dir, string type)
        {
            foreach (var file in dir.GetFiles("*" + type))
            {
                Console.WriteLine(file.Name + ", " + file.Length + " bytes, " + file.CreationTime);
            }
            var subdirectories = dir.GetDirectories();
            foreach (var subdirectory in subdirectories)
                FilesOfType(subdirectory, type);
        }

        static void SearchForContent(DirectoryInfo dir, string type, string key)
        {
            
            foreach (var file in dir.GetFiles())
            {
                string content = File.ReadAllText(file.ToString());
                if(content.IndexOf(key) != -1)
                    Console.WriteLine(file.Name + ", " + file.Length + " bytes, " + file.CreationTime);
                var subdirectories = dir.GetDirectories();
                foreach (var subdirectory in subdirectories)
                    SearchForContent(subdirectory, type, key);
            }
        }
    }
}
