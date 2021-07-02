using System;
using LaskentaaYms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Harjoitus har = new Harjoitus();
            Console.WriteLine(har.IndeksiKorotus(50, "-"));
        }
    }
}
