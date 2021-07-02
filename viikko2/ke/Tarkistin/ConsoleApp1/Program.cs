using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "saippuakauppias";
            var str = s.Split(" ");
            s = String.Join("", str);
            string r = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                r += s[i];
            }

            Console.WriteLine(s==r);
        }
    }
}
