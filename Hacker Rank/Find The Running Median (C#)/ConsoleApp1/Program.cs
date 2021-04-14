using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the runningMedian function below.
     */
    static double[] runningMedian(int[] a)
    {
        throw new NotImplementedException();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("TESTE", true);

        int aCount = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[aCount];

        for (int aItr = 0; aItr < aCount; aItr++)
        {
            int aItem = Convert.ToInt32(Console.ReadLine());
            a[aItr] = aItem;
        }

        double[] result = runningMedian(a);

        textWriter.WriteLine(string.Join("\n", result)); //TODO: fix result format

        textWriter.Flush();
        textWriter.Close();
    }
}
