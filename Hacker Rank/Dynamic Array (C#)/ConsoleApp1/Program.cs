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
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        var result = new List<int>();

        var arr = new int[n][];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new int[0];
        }

        var lastAnswer = 0;

        for (var i = 0; i < queries.Count(); i++)
        {
            if (queries[i][0] == 1)
            {
                var query = (queries[i][1] ^ lastAnswer) % n;
                arr[query] = arr[query].Append(queries[i][2]).ToArray();
            }

            if (queries[i][0] == 2)
            {
                var arrCalculated = arr[(queries[i][1] ^ lastAnswer) % n];
                lastAnswer = arrCalculated[queries[i][2] % arrCalculated.Count()];
                result.Add(lastAnswer);
                Console.WriteLine(lastAnswer);
            }
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"TESTE", true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
