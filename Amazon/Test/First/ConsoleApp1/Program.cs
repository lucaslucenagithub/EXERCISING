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
     * Complete the 'mergeFiles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY fileSizes as parameter.
     */

    public static int mergeFiles(List<int> fileSizes)
    {
        int result = 0;

        while (fileSizes.Count > 1)
        {
            int firstMinimunFileSize = fileSizes.Min();
            fileSizes.Remove(firstMinimunFileSize);

            int secondMinimunFileSize = fileSizes.Min();
            fileSizes.Remove(secondMinimunFileSize);

            int mergeCost = firstMinimunFileSize + secondMinimunFileSize;
            fileSizes.Add(mergeCost);

            result += mergeCost;
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("TESTE", true);

        int fileSizesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> fileSizes = new List<int>();

        for (int i = 0; i < fileSizesCount; i++)
        {
            int fileSizesItem = Convert.ToInt32(Console.ReadLine().Trim());
            fileSizes.Add(fileSizesItem);
        }

        int result = Result.mergeFiles(fileSizes);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
