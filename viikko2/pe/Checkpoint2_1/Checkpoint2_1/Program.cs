using System;
using System.IO;
using System.Linq;

namespace Checkpoint2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna hakemistonnimi:");
            string dirpath = Console.ReadLine();
            Console.WriteLine("Anna tiedostonnimi (tai osa siitä):");
            string filename = Console.ReadLine();
            if (!Directory.Exists(dirpath))
            {
                Console.WriteLine("Annettu hakemisto ei ole olemassa!");
                return;
            }
            DirectoryInfo dir = new DirectoryInfo(dirpath);
            var q = from file in dir.GetFiles()
                    where file.Name == filename || file.Name.Contains(filename)
                    orderby file.CreationTime descending
                    select file;
            if(q.Count() == 0)
            {
                Console.WriteLine("Hakemistosta ei löytynyt tiedostoa annetulla ehdolla");
            }
            else
            {
                foreach (var item in q)
                {
                    Console.WriteLine("Tiedostonnimi: " + item.Name + ", luontiaika: " + item.CreationTime +
                        ", koko: " + item.Length);
                }
            }
        }
    }
}
