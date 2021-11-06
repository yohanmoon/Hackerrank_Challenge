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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int pNumbers = 0;
        int nNumbers = 0;
        int zNumbers = 0;



        foreach (var a in arr)
        {
            if (a > 0)
            {
                pNumbers++;
            }
            else if (a < 0)
            {
                nNumbers++;
            }
            else
            {
                zNumbers++;
            }
        }

        double pResult = (double)pNumbers / arr.Count;
        double nResult = (double)nNumbers / arr.Count;
        double zResult = (double)zNumbers / arr.Count;

        Console.WriteLine("{0:N6}", pResult);
        Console.WriteLine(nResult.ToString("N6"));
        Console.WriteLine("{0:N6}", zResult);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);

    }
}
