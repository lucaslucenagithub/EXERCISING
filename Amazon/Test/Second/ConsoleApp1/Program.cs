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
     */

    public static int minimumDistance(List<List<int>> area)
    {
        int result = 0;

        for (int i = 0; i < area.Count; i++)
        {
            for (int j = 0; j < area[i].Count; j++)
            {
                if (area[i][j] == 1 && area[i][j + 1] == 0)
                {
                    result += 1;
                    break;
                }
                else if (area[i][j] == 1 && area[i][j + 1] == 9)
                {
                    result += 1;
                    break;
                }
                else
                {
                    result += 2;
                }
            }
        }

        return result;
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

        int result = Result.minimumDistance(area);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
