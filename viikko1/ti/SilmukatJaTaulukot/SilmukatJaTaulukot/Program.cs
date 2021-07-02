using System;

namespace SilmukatJaTaulukot
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5] { 55, 34, 71, 29, 83 };
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = sum / 5.0;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 1000);
            }

            Console.WriteLine("--------------------------\n");
            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = sum / 5.0;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);

            Console.WriteLine("--------------------------\n");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            int smallest = numbers[0], largest = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (smallest > numbers[i + 1])
                    smallest = numbers[i + 1];
                if (largest < numbers[i + 1])
                    largest = numbers[i + 1];
            }

            Console.WriteLine("Smallest = " + smallest);
            Console.WriteLine("Largest = " + largest);
        }
    }
}
