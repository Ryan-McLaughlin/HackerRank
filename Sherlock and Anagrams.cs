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
    public static int sherlockAndAnagrams(string s)
    {
        int count = 0;
        Dictionary<string, int> subCounts = new Dictionary<string, int>();
        
        for (int length = 1; length < s.Length; length++)
        {
            for (int i =0; i <= s.Length - length; i++)
            {
                string sub = s.Substring(i, length);
                string sortedSub;
                char[] charArray = sub.ToCharArray();
                
                Array.Sort(charArray);
                sortedSub = new string(charArray);
                
                if (subCounts.ContainsKey(sortedSub))
                {
                    subCounts[sortedSub]++;                    
                }
                else
                {
                    subCounts[sortedSub] = 1;
                }
            }
        }
        
        foreach (int subCount in subCounts.Values)
        {
            count += subCount * (subCount - 1) / 2;
        }
        
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
