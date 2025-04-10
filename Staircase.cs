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
    public static void staircase(int n)
    {
        for (int i = n; i > 0; i--) {
            for (int j = i - 1; j > 0; j--) {
                Console.Write(" ");
            }
            for (int j = i - 1; j < n; j++) {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}