using System;
using System.IO;

namespace Arkistoi
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(args[0]);
            Archive(dir, "cs");
        }

        static void Archive(DirectoryInfo dir, string type)
        {
            var archive = "c:/users/muhsen/source/repos/V1/torstai/Arkistoi/Arkisto";
            if (!Directory.Exists(archive))
            {
                Directory.CreateDirectory(archive);
            }
            foreach (var file in dir.GetFiles("*." + type))
            {
                file.CopyTo(archive+"koodi.cs");
            }
            var subdirectories = dir.GetDirectories();
            foreach (var subdirectory in subdirectories)
                Archive(subdirectory, type);
        }
    }
}
