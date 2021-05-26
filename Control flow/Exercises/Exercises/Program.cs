using System;

namespace Exercises
{
    class Program
    {
        public void Exercise1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine(count);
        }

        public void Exercise2()
        {
            double count = 0;
            while (true)
            {
                Console.WriteLine("Enter a number: (ok exits)");
                var input = Console.ReadLine();
                if (input.ToLower().Equals("ok"))
                    break;
                count = count + double.Parse(input);
            }

            Console.WriteLine(count);
        }

        public void Exercise3()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int factorial = number;
            for (int i = factorial-1; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"{number}! = {factorial}");
        }

        public void Exercise4()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.WriteLine(randomNumber);
            int input;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess my number:");
                input = int.Parse(Console.ReadLine());

                if (input == randomNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }

            }

            Console.WriteLine("You Lost!");
        }

        public void Exercise5()
        {
            Console.WriteLine("enter a series of numbers separated by comma:");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = int.Parse(numbers[0]);
            foreach (var str in numbers)
            {
                var number = int.Parse(str);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine(max);
        }
    }
}
