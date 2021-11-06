﻿using System.CodeDom.Compiler;
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
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        /* First way of solving
        int aWin = 0;
        int bWin = 0;
        
        
        for (int i = 0 ; i<a.Count; i++)
        {
            if(a[i]>b[i])
            {
                aWin++;
            }
            else if (a[i]<b[i])
            {
                bWin++;
            }
        }
            List<int> nlist = new List<int> {aWin,bWin};
        return nlist;
        */

        List<int> ab = new List<int> { 0, 0 };
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                ab[0]++;
            }
            else if (a[i] < b[i])
            {
                ab[1]++;
            }

        }
        return ab;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}