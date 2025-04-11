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
    public static string encryption(string s)
    {
        // Remove all spaces from the input string 's'.
        string condensed = Regex.Replace(s, @"\s+", "");

        // Calculate the number of rows and columns for the grid.
        // 'rows' is the floor of the square root of the string's length.
        // 'cols' is the ceiling of the square root of the string's length.
        int rows = (int)Math.Floor(Math.Sqrt(condensed.Length));
        int cols = (int)Math.Ceiling(Math.Sqrt(condensed.Length));
        
        // Adjust the number of rows if the grid is not large enough to hold all characters.
        // If the product of rows and columns is less than the string's length, increment rows.
        if (rows * cols < condensed.Length)
        {
            rows += 1;
        }
        
        // Create a 2D character array (grid) to store the characters.
        char[,] cArr = new char[rows, cols];
        
        // Initialize an index to track the current character in the condensed string.
        int index = 0;
        
        // Fill the grid with characters from the condensed string.
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // If there are more characters in the string, add them to the grid.
                if (index < condensed.Length)
                {
                    cArr[row, col] = condensed[index++];
                }
                // If the string is exhausted, fill the remaining grid cells with spaces.
                else
                {
                    cArr[row, col] = ' ';
                }
            }
        }
        
        // Initialize an empty string to store the encrypted result.
        string encrypt = "";
        
        // Read the grid column by column to create the encrypted string.
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                // Print the character at the current grid cell (for debugging/console output).
                Console.Write(cArr[row, col]);
                
                // Append the character to the encrypted string, excluding spaces.
                if (cArr[row, col] != ' ')
                {
                    encrypt += cArr[row, col];
                }
                // If a space is encountered, break the inner loop (end of column data).
                else break;
            }
            // Append a space to the encrypted string after each column's characters.
            Console.Write(" ");
            encrypt += " ";
        }
        
        // Return the encrypted string.
        return encrypt;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}