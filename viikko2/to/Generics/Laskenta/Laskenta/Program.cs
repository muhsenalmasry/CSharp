using System;

namespace Laskenta
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiSet<string, int> multi = new();
            multi.Add("First", 5);
            multi.Add("First", 4);
            multi.Add("First", 9);
            multi.Remove("First", 0);
            Console.WriteLine(multi["First"]);
            multi.Remove("First");
            multi.Remove("First");
            Console.WriteLine(multi.ItemCount("First"));
        }
    }
}
