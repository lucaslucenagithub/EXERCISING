using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        class Coordinates
        {
            public int X;
            public int Y;

            public Coordinates(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public static void floodFillWithRecursion(int[][] screen, int x, int y, int newColor, int prevColor)
        {
            // Base cases
            if (x < 0 || x >= 8 ||
                y < 0 || y >= 8)
                return;
            if (screen[x][y] != prevColor)
                return;

            // Replace the color at (x, y)
            screen[x][y] = newColor;

            // Recur for north, east, south and west
            floodFillWithRecursion(screen, x + 1, y, newColor, prevColor);
            floodFillWithRecursion(screen, x - 1, y, newColor, prevColor);
            floodFillWithRecursion(screen, x, y + 1, newColor, prevColor);
            floodFillWithRecursion(screen, x, y - 1, newColor, prevColor);
        }

        public static int validCoord(int x, int y, int n, int m)
        {
            if (x < 0 || y < 0)
            {
                return 0;
            }
            if (x >= n || y >= m)
            {
                return 0;
            }
            return 1;
        }

        public static void floodFillWithBFS(int[][] screen, int x, int y, int newColor)
        {
            // Visiting array
            int[,] vis = new int[101, 101];
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    vis[i, j] = 0;
                }
            }

            // Creating queue for bfs
            Queue<Coordinates> queue = new Queue<Coordinates>();

            // Pushing pair of {x, y}
            Coordinates initialIndex = new Coordinates(x, y);
            queue.Enqueue(initialIndex);
            // Marking {x, y} as visited
            vis[x, y] = 1;

            // Untill queue is emppty
            while (queue.Count > 0)
            {
                // Extrating front pair
                Coordinates coords = queue.Peek();
                int crossAxis = coords.X;
                int horizontalAxis = coords.Y;
                int previousColor = screen[crossAxis][horizontalAxis];

                screen[crossAxis][horizontalAxis] = newColor;

                // Poping front pair of queue
                queue.Dequeue();

                // For Upside Pixel or Cell
                if ((validCoord(crossAxis - 1, horizontalAxis, 8, 8) == 1) && vis[crossAxis + 1, horizontalAxis] == 0 && screen[crossAxis + 1][horizontalAxis] == previousColor)
                {
                    Coordinates p = new Coordinates(crossAxis + 1, horizontalAxis);
                    queue.Enqueue(p);
                    vis[crossAxis + 1, horizontalAxis] = 1;
                }

                // For Downside Pixel or Cell
                if ((validCoord(crossAxis + 1, horizontalAxis, 8, 8) == 1) && vis[crossAxis - 1, horizontalAxis] == 0 && screen[crossAxis - 1][horizontalAxis] == previousColor)
                {
                    Coordinates p = new Coordinates(crossAxis - 1, horizontalAxis);
                    queue.Enqueue(p);
                    vis[crossAxis - 1, horizontalAxis] = 1;
                }

                // For Right side Pixel or Cell
                if ((validCoord(crossAxis, horizontalAxis + 1, 8, 8) == 1) && vis[crossAxis, horizontalAxis + 1] == 0 && screen[crossAxis][horizontalAxis + 1] == previousColor)
                {
                    Coordinates p = new Coordinates(crossAxis, horizontalAxis + 1);
                    queue.Enqueue(p);
                    vis[crossAxis, horizontalAxis + 1] = 1;
                }

                // For Left side Pixel or Cell
                if ((validCoord(crossAxis, horizontalAxis - 1, 8, 8) == 1) && vis[crossAxis, horizontalAxis - 1] == 0 && screen[crossAxis][horizontalAxis - 1] == previousColor)
                {
                    Coordinates p = new Coordinates(crossAxis, horizontalAxis - 1);
                    queue.Enqueue(p);
                    vis[crossAxis, horizontalAxis - 1] = 1;
                }
            }
        }

        static void Main(string[] args)
        {
            var screen = new int[8][]
            {
                new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1, 1, 1, 0, 0 },
                new int[] { 1, 0, 0, 1, 1, 0, 1, 1 },
                new int[] { 1, 2, 2, 2, 2, 0, 1, 0 },
                new int[] { 1, 1, 1, 2, 2, 0, 1, 0 },
                new int[] { 1, 1, 1, 2, 2, 2, 2, 0 },
                new int[] { 1, 1, 1, 1, 1, 2, 1, 1 },
                new int[] { 1, 1, 1, 1, 1, 2, 2, 1 }
            };

            int x = 4;
            int y = 4;
            int newColor = 3;

            floodFillWithBFS(screen, x, y, newColor);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(screen[i][j] + " ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
