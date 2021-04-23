using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'minimumDistance' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY area as parameter.
     * 
     * O(area * area[i])
     */

    public static int minimumDistanceBruteForceNotWorking(List<List<int>> area)
    {
        int result = 0;
        bool endPointReached = false;

        for (int i = 0; i < area.Count; i++)
        {
            var currentArea = area[i];

            for (int j = 0; j < currentArea.Count; j++)
            {
                if (i == 0 && j == 0)
                {
                    continue;
                }

                if (currentArea[j] == 0)
                {
                    if (currentArea[j + 1] != 0) break;

                    continue;
                }

                if (currentArea[j] == 1)
                {
                    result += 1;
                    continue;
                }

                if (currentArea[j] == 9)
                {
                    result += 1;
                    endPointReached = true;
                    break;
                }
            }

            if (currentArea.Contains(9) && result > 0) break;

            if (!endPointReached && i == area.Count - 1) i = -1;
        }

        return result;
    }

    /*
     * Complete the 'minimumDistance' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY area as parameter.
     */
    public static int minimumDistanceOptimized(List<List<int>> area)
    {
       
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("TESTE", true);

        int areaRows = Convert.ToInt32(Console.ReadLine().Trim());
        int areaColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> area = new List<List<int>>();

        for (int i = 0; i < areaRows; i++)
        {
            area.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(areaTemp => Convert.ToInt32(areaTemp)).ToList());
        }

        int result = Result.minimumDistanceOptimized(area);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
