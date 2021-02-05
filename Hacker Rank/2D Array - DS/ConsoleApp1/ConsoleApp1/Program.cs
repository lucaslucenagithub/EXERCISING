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

class Solution
{
    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        var hourGlassesSum = new int[16];

        var hourGlassesCompleted = 0;
        for (int totalHourGlasses = 0; hourGlassesCompleted < 16; totalHourGlasses++)
        {
            for (int sequencePerRow = 0; sequencePerRow < 4; sequencePerRow++)
            {
                for (int top = 0; top < 3; top++)
                {
                    hourGlassesSum[hourGlassesCompleted + sequencePerRow] += arr[totalHourGlasses][sequencePerRow + top];
                }

                for (int mid = 1; mid < 2; mid++)
                {
                    hourGlassesSum[hourGlassesCompleted + sequencePerRow] += arr[totalHourGlasses + 1][sequencePerRow + mid];
                }

                for (int bottom = 0; bottom < 3; bottom++)
                {
                    hourGlassesSum[hourGlassesCompleted + sequencePerRow] += arr[totalHourGlasses + 2][sequencePerRow + bottom];
                }
            }

            hourGlassesCompleted += 4;
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
