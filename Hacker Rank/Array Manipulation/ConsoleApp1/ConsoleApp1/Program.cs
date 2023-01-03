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
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    //public static long arrayManipulation(int n, List<List<int>> queries)
    //{
    //int aux = 0;
    //int[] arr = new int[n];

    //for (int i = 0; i < queries.Count; i++)
    //{
    //    List<int> insert = queries[i];

    //    for (int j = insert[0]; j <= insert[1]; j++)
    //    {
    //        arr[j - 1] = arr[j - 1] == 0 ? insert[2] : arr[j - 1] + insert[2];

    //        aux = arr[j - 1] > aux ? arr[j - 1] : aux;
    //    }
    //}

    //return aux;

    //var largestIdx = 0;
    //var largestVal = 0;
    //var minCommonInterval = 0;

    //for (int i = 0; i < queries.Count; i++)
    //{
    //    List<int> insert = queries[i];

    //    if (i == 0)
    //    {
    //        largestIdx = insert[1];
    //        largestVal = insert[2];

    //        continue;
    //    }

    //    if (insert[0] <= largestIdx)
    //    {
    //        if (minCommonInterval == 0) minCommonInterval = insert[0];

    //        if (insert[0] <= minCommonInterval || insert[1] <= minCommonInterval)
    //        {
    //            minCommonInterval = insert[0];
    //            largestVal += insert[2];
    //        }
    //    }

    //    if (insert[1] > largestIdx)
    //    {
    //        largestIdx = insert[1];
    //    }
    //}

    //return largestVal;

    //int aux = 0;
    //int[] arr = new int[n];

    //for (int i = 0; i < queries.Count; i++)
    //{
    //    List<int> insert = queries[i];

    //    arr[insert[0] - 1] += insert[2];
    //    arr[insert[1] - 1] -= insert[2];
    //}

    //for (int i = 1; i < n; i++)
    //{
    //    arr[i] = arr[i] + arr[i - 1];

    //    if (arr[i] > aux)
    //    {
    //        aux = arr[i];
    //    }
    //}

    //return aux;
    //}

    public static long arrayManipulation(int n, List<List<int>> queries)
    {
        long[] arr = new long[n+1];
        long maxValue = 0;

        for (int j = 0; j < queries.Count; j++)
        {
            var initialPosition = queries[j][0];
            var finalPosition = queries[j][1];
            var addValue = queries[j][2];

            arr[initialPosition - 1] += addValue;
            arr[finalPosition] -= addValue;
        }

        for (int i = 1; i < n; i++)
        {
            arr[i] = arr[i] + arr[i - 1];

            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
        }

        return maxValue;
    }

    //public static long arrayManipulation(int n, List<List<int>> queries)
    //{
    //    //Declaring de arr with n+1, so you can make the entire range when add the first and last value
    //    long[] arr = new long[n + 1];
    //    long maxValue = 0;

    //    for (int a = 0; a < n; a++)
    //    {

    //        arr[a] = 0;
    //    }

    //    for (int j = 0; j < queries.Count; j++)
    //    {

    //        var initialPosition = queries[j][0];
    //        var finalPosition = queries[j][1];
    //        var addValue = queries[j][2];

    //        //To make the sum happens you only need to add the value to the first position based on array (initialPosition -1) and the negative value on the final position based on the position itselfe (finalPosition).
    //        arr[initialPosition - 1] += addValue;
    //        arr[finalPosition] -= addValue;
    //    }

    //    for (int i = 1; i < n; i++)
    //    {
    //        //With the values made at the previously step, you can sum all the values, with the previously value in the array, and then get the max value that a position can reach.      
    //        //You maybe want ask why we get the negative values on de finalPosition. We do this to get the real intersetion between the given ranges. If we get 1 3 100, and 2 3 100, the intersetion will be on position 2 and 3, that will have 200 value. And when we enter in this for to sum the values, if the position 3 was positive, then the arr[3] will be 300. Thats Why We put the negative.
    //        arr[i] = arr[i] + arr[i - 1];

    //        if (arr[i] > maxValue)
    //        {
    //            maxValue = arr[i];
    //        }
    //    }

    //    return maxValue;
    //}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(/*@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")*/ "TEST", true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        long result = Result.arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
