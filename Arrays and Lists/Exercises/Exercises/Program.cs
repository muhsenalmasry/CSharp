using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        public void Exercise1()
        {
            string name;
            var names = new List<string> ();
            while (true)
            {
                Console.WriteLine("Enter a name:");
                name = Console.ReadLine();
                if (name == "")
                    break;

                names.Add(name);
            }

            if (names != null)
                switch (names.Count)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine($"{names[0]} likes your post");
                        break;
                    case 2:
                        Console.WriteLine($"{names[0]} and {names[1]} like your post");
                        break;
                    default:
                        Console.WriteLine($"{names[0]} and {names[1]} and {names.Count-2} others like your post");
                        break;
                }
        }

        public void Exercise2()
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            var array = new char[name.Length];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = name[i];
            }
            Array.Reverse(array);
            name = new string(array);
            Console.WriteLine(name);
        }

        public void Exercise3()
        {
            var numbers = new int[5];

            var i = 0;
            while (numbers.Length < 5)
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine($"{number} was previously entered, please enter a different number:");
                    continue;
                }
                
                numbers[i] = number;

                i++;
            }

            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            

        }

        public void Exercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number, or type \"Quit\" to exit");
                var number = Console.ReadLine();
                if (number.ToLower() == "quit")
                    break;
                numbers.Add(int.Parse(number));
            }
            
            foreach (var n in numbers)
            {
                if (numbers.LastIndexOf(n) == numbers.IndexOf(n))
                    Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {

            /*List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a series of numbers seperated by comma (eg. 1,2,3,4):");
                var input = Console.ReadLine();
                var array = input.Split((','));
                if (array.Length < 5)
                {
                    Console.WriteLine("Invalid list! Please retry.");
                    continue;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    numbers.Add(int.Parse(array[i]));
                }
                break;
            }
            
            numbers.Sort();
            Console.WriteLine($"The three smallest numbers in the list are:" +
                              $"\n{numbers[0]}" +
                              $"\n{numbers[1]}" +
                              $"\n{numbers[2]}");
            */

            var name = "Muhsen";
            name[0] = 'm';
            Console.WriteLine(name);


        }
    }
}
