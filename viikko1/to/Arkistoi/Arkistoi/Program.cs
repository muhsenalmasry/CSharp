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
            for (int i = 1; i <= dir.GetFiles("*." + type).Length; i++)
            {
                var file = dir.GetFiles("*." + type)[i-1];
                if (!File.Exists("koodi.cs"))
                {
                    var f = File.Create("koodi.cs");
                    file.CopyTo(archive + "/koodi.cs");
                    f.Close();
                }
                else
                {
                    if(!File.Exists("koodi" + i + ".cs"))
                    {
                        var f = File.Create("koodi" + i + ".cs");
                        file.CopyTo(archive+"/koodi" + i + ".cs");
                        f.Close();
                    }
                    else
                    {
                        var f = File.Create("koodi" + i + 1 + ".cs");
                        file.CopyTo(archive + "/koodi" + i + 1 + ".cs");
                        f.Close();
                    }
                }
            }
            var subdirectories = dir.GetDirectories();
            foreach (var subdirectory in subdirectories)
                Archive(subdirectory, type);
        }
    }
}
