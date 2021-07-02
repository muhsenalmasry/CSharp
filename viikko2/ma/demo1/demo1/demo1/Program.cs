using System;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lkm = 50;

            for (int i = 0; i < lkm; i++)
            {
                Console.Write((char)((int) 'ä' + i));
            }
        }
    }
}
