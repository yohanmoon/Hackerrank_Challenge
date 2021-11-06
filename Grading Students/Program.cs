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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {

        //for (int i = 0; i < grades.Count; i++)
        //{
        //    int roundUp = ((grades[i] + 2) / 5 * 5) - grades[i];
        //    int roundedUp = 0;
        //    if (grades[i] < 38 || roundUp < 0)
        //    {
        //        grades[i] = grades[i];
        //    }

        //    else if (roundUp < 3)
        //    {
        //        roundedUp = (grades[i] + 2) / 5 * 5;
        //        grades[i] = roundedUp;
        //    }


        //}
        //return grades;

        for (int i = 0; i < grades.Count; i++)
        {
            int fives = (grades[i] / 5 + 1) * 5;
            if (grades[i] >= 38)
            {
                if (fives - grades[i] < 3)
                {
                    grades[i] = fives;
                }
            }



        }
        return grades;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
