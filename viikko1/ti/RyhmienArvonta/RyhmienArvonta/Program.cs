using System;
using System.Collections.Generic;
using System.IO;

namespace RyhmienArvonta
{
    class Program
    {
        static void Main(string[] args)
        {
            var consultants = new List<string>();
            var input = new StreamReader("c:/users/muhsen/desktop/konsultit.txt");
            var output = new StreamWriter("c:/users/muhsen/desktop/ryhmät.txt");
            while(input.Peek() != -1)
            {
                consultants.Add(input.ReadLine());
            }
            /*
            while (consultants.Count > 0)
            {

                Random random = new Random();
                int index = random.Next(0, consultants.Count);
                Console.WriteLine(consultants[index]);
                consultants.RemoveAt(index);
            }
            */
            string ryhmät = "";
            Random random = new Random();
            Console.WriteLine("Group size: (nothing = default)");
            string gSize = Console.ReadLine();
            if (!gSize.Equals(""))
            {
                double groupSize = Convert.ToDouble(gSize);
                int j = 1;
                while(consultants.Count > 0)
                {
                    Console.WriteLine("Array size: " + consultants.Count);
                    ryhmät += "Ryhmä " + j + "\n";
                    if (consultants.Count >= groupSize)
                    {
                        for (int i = 0; i < groupSize; i++)
                        {
                            int index = random.Next(0, consultants.Count);
                            ryhmät += consultants[index] + "\n";
                            consultants.RemoveAt(index);
                        }
                    }
                    else
                    {
                        for(int i = 0; i <= consultants.Count; i++)
                        {
                            int index = random.Next(0, consultants.Count);
                            ryhmät += consultants[index] + "\n";
                            consultants.RemoveAt(index);
                        }
                    }
                    j++;
                }
            }
            else
            {
                int j = 1;
                while (consultants.Count > 0)
                {
                    Console.WriteLine("Array size: " + consultants.Count);
                    ryhmät += "Ryhmä " + j + "\n";
                    if (consultants.Count >= 3)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int index = random.Next(0, consultants.Count);
                            ryhmät += consultants[index] + "\n";
                            consultants.RemoveAt(index);
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= consultants.Count; i++)
                        {
                            int index = random.Next(0, consultants.Count);
                            ryhmät += consultants[index] + "\n";
                            consultants.RemoveAt(index);
                        }
                    }
                    j++;
                }
            }

            Console.WriteLine(ryhmät);

            output.Write(ryhmät);
            output.Close();
            
        }
    }
}
