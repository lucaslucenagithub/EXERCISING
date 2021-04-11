using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
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
            int prevColor = screen[x][y];

            floodFillWithRecursion(screen, x, y, newColor, prevColor);

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
