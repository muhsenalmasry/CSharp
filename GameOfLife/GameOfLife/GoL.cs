using System;

namespace GameOfLife
{
    public class GoL
    {
        public int Width { get; }
        public int Height { get; }
        public int Generation { get; }
        public int[,] Cells { get; set; }


        public GoL()
        {

        }

        public GoL(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new int[height, width];
        }

        public void SetCell(int x, int y, bool alive)
        {
            if (alive == true)
                Cells[x, y] = 1;
            else if(alive == false)
                Cells[x, y] = 0;

        }

        public bool IsCellAlive(int x, int y)
        {
            if (Cells[x, y] == 0)
            {
                return false;

            }
            return true;
        }

        public int NumberOfNeighbors(int x, int y)
        {
            int neighbors = 0;
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= Height || j >= Width)))
                    {
                        if (!((i == x) && (j == y)))
                        {
                            if (IsCellAlive(i, j))
                                neighbors++;
                        }
                    }
                }
            }
            return neighbors;
        }

        public bool NextGeneration()
        {
            bool next = false;
            var temp = new int[Height, Width];

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (Cells[i, j] == 0)
                    {
                        if (NumberOfNeighbors(i, j) == 3)
                        {
                            temp[i,j] = 1;
                            next = true;
                        }
                        else
                        {
                            temp[i,j] = 0;
                        }

                    }
                    else
                    {
                        if (!(NumberOfNeighbors(i, j) == 2 || NumberOfNeighbors(i, j) == 3))
                        {
                            temp[i,j] = 0;
                            next = true;
                        }
                        else
                        {
                            temp[i,j] = 1;
                        }
                    }
                }
            }

            for (int i = 0; i < Height; i++)
			{
                for (int j = 0; j < Width; j++)
			{
                    Cells[i,j] = temp[i,j];
			}
			}
            return next;
        }


        public void SaveGame(string filename)
        {

        }

        public bool LoadGame(string filename)
        {
            return true;
        }
    }
}
