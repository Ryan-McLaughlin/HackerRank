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
    public static void plusMinus(List<int> arr)
    {
        int[] charge = new int[3];
        charge[0] = charge[1] = charge[2] = 0;

        for (int i = 0; i < arr.Count; i++)
		{
            if (arr[i] < 0) {charge[0] ++;}
            else if (arr[i] > 0) {charge[1] ++;}
			else {charge[2]++;}
            
        }
		
        Console.WriteLine((float)charge[1]/arr.Count);
        Console.WriteLine((float)charge[0]/arr.Count);
        Console.WriteLine((float)charge[2]/arr.Count);
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