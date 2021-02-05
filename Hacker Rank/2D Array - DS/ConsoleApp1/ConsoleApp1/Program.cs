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

//NOT FINISHED YET
class Solution
{
    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        var hourGlasses = new int[16][];
        var hourGlassesSum = new int[16];

        for (int i = 0; i < hourGlasses.Count(); i++)
        {
            hourGlasses[i] = new int[7]; 
        }

        for (int i = 0; i < 16; i++)
        {
            var hourglassPosition = 0;

            for (int top = 0; top < 3; top++)
            {
                hourGlasses[i][hourglassPosition] = arr[i][i + top];
                ++hourglassPosition;
            }

            for (int mid = 1; mid < 2; mid++)
            {
                hourGlasses[i][hourglassPosition] = arr[i + 1][i + mid];
                ++hourglassPosition;
            }

            for (int bottom = 0; bottom < 3; bottom++)
            {
                hourGlasses[i][hourglassPosition] = arr[i + 2][i + bottom];
                ++hourglassPosition;
            }
        }

        for (int i = 0; i < hourGlasses.Count(); i++)
        {
            hourGlassesSum[i] = hourGlasses[i].Sum();
        }

        return hourGlassesSum.Max();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("TEST", true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
