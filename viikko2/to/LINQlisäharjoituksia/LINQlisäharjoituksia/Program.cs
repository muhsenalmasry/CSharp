using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace LINQlisäharjoituksia
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*var q = from process in Process.GetProcesses()
                    orderby process.WorkingSet64 descending
                    select process;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(q.ElementAt(i).SessionId + "\t\t" + q.ElementAt(i).ProcessName + "\t\t" + q.ElementAt(i).WorkingSet64);
            }
            Console.WriteLine("\n\n----------------\n\n");
            q = from process in Process.GetProcesses()
                orderby process.WorkingSet64 ascending
                select process;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(q.ElementAt(i).SessionId + "\t\t" + q.ElementAt(i).ProcessName + "\t\t" + q.ElementAt(i).WorkingSet64);
            }
            */
            Console.WriteLine("Anna hakemiston sijainti:");
            string path = Console.ReadLine();
            if(!Directory.Exists(path))
            {
                Console.WriteLine($"Directory {path} is invalid");
                return;
            }
            string[] subdirnames = Directory.GetDirectories(path);
            List<Tuple<string, long>> tulos = new List<Tuple<string, long>>();
            foreach (var item in subdirnames)
            {
                DirectoryInfo di = new DirectoryInfo(item);
                long dirSize = di.GetFiles("*", SearchOption.AllDirectories).Sum(f => f.Length);
                Console.WriteLine($"{item}: {dirSize/ (1024*1024)} MB");
            }
            
        }

    }   
}
