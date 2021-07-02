using System;

namespace Numeropähkinä
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 25; i++)
            {
                for (int j = i; j < i+1 ; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
