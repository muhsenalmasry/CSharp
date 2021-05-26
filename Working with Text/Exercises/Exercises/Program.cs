using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        public void Exercise1()
        {
            Console.WriteLine("Enter few numbers separated with hyphen:");
            var input = Console.ReadLine();
            var array = input.Split('-');
            
            var numbers = new List<int>();
            foreach (var item in array)
            {
                numbers.Add(Convert.ToInt32(item));   
            }

            numbers.Sort();
            bool isConsecutive = (numbers[numbers.Count-1] - numbers[0] == numbers.Count - 1) ? true : false;

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Non consecutive");
            }
        }

        public void Exercise2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen:");
            var input = Console.ReadLine();
            while (!String.IsNullOrWhiteSpace(input))
            {
                var array = input.Split('-');
                var numbers = new List<int>();
                bool isDuplicated = false;
                foreach (var s in array)
                {
                    numbers.Add(Convert.ToInt32(s));
                }

                foreach (var number in numbers)
                {
                    if (numbers.IndexOf(number) != numbers.LastIndexOf(number))
                        isDuplicated = true;
                }

                if (isDuplicated)
                {
                    Console.WriteLine("Duplicated");
                }

                break;
            }

        }


        public void Exercise3()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format:");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time!");
                return;
            }

            if (input.Split(':').Length != 2)
            {
                Console.WriteLine("Invalid time!");
                return;
            }
            

            try
            {
                var hours = Convert.ToInt32(input.Split(':')[0]);
                var minutes = Convert.ToInt32((input.Split(':')[1]));
                if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Invalid time!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid time!");
            }

        }


        public void Exercise4()
        {
            Console.WriteLine("Enter a few words separated by a space:");
            var input = Console.ReadLine();
            var array = input.Split(' ');
            var pascalCase = "";
            foreach (var word in array)
            {
                pascalCase += char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }

            Console.WriteLine(pascalCase);
        }


        public void Exercise5()
        {
            Console.WriteLine("Enter an english word:");
            var input = Console.ReadLine();
            var vocals = 0;
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'y':
                    case 'u':
                    case 'i':
                    case 'o':
                    case 'w':
                    case 'å':
                    case 'ä':
                    case 'ö':
                        vocals += 1;
                        break;
                }
            }

            Console.WriteLine(vocals);

        }
    }
}
