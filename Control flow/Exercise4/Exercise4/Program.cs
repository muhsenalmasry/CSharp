using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wnter speed limit:");
            double speedLimit = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car:");
            double carSpeed = double.Parse(Console.ReadLine());

            int demerit = 0;

            if(carSpeed <= speedLimit)
                Console.WriteLine("OK");
            else
            {
                demerit = (int)(carSpeed - speedLimit) / 5;
                if(demerit < 12)
                    Console.WriteLine("Demerit points: " + demerit);
                else
                    Console.WriteLine("License suspended");
            }
        }
    }
}
