using System;
using System.Collections.Generic;
using System.Threading;
using GameOfLife;

namespace Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0, height = 0;
            List<string> list = new List<string>();
            do
            {
                string s = Console.ReadLine();
                if (s == "" || s == " ")
                    break;
                if (s.Length > width)
                    width = s.Length;
                list.Add(s);
                height++;
            } while (true);

            Console.WriteLine("\nNumber of generations to execute:");
            int gen = Convert.ToInt32(Console.ReadLine());

            GoL game = new GoL(width, height);

            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (list[i].Length - 1 < j)
                        game.SetCell(i, j, false);
                    else
                    {
                        if (list[i][j] == '0')
                            game.SetCell(i, j, false);
                        else if (list[i][j] == '1')
                            game.SetCell(i, j, true);
                    }
                    

                    
                }
            }

            Console.Clear();
            /*
            Console.WriteLine("Cell (0,0) is alive? " + game.IsCellAlive(0,0));
            Console.WriteLine("Number of neighbors of 0,0 is : " + game.NumberOfNeighbors(0,0));
            Console.WriteLine("next generation..");
            game.NextGeneration();
            Console.WriteLine("Cell (0,0) is alive? " + game.IsCellAlive(1,1));
            Console.WriteLine("Number of neighbors of 0,0 is : " + game.NumberOfNeighbors(0, 0));
            */
            for (int k = 0; k < gen; k++)
            {
                for (int i = 0; i < game.Height; i++)
                {
                    for (int j = 0; j < game.Width; j++)
                    {
                        if (game.IsCellAlive(i, j))
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                game.NextGeneration();
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
    }
}
