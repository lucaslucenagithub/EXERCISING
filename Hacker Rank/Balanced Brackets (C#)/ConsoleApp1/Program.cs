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

class Solution
{

    // Complete the isBalanced function below.
    static string isBalanced(string s)
    {
        char[] openingBrackets = new char[] { '{', '(', '[' };
        char[] closingBrackets = new char[] { '}', ')', ']' };
        char[] brackets = s.TrimEnd().ToCharArray();
        Stack<char> stack = new Stack<char>();

        if (
            closingBrackets.Contains(brackets[0]) ||
            openingBrackets.Contains(brackets[brackets.Length - 1])
        )
        {
            Console.WriteLine("NO");
            return "NO";
        }

        for (int i = 0; i < brackets.Length; i++)
        {
            if (openingBrackets.Contains(brackets[i]))
            {
                stack.Push(brackets[i]);
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("NO");
                    return "NO";
                }

                char closingBracket = brackets[i];
                char openingBracket = stack.Pop();

                if (openingBracket == '[' && closingBracket != ']')
                {
                    Console.WriteLine("NO");
                    return "NO";
                }
                else if (openingBracket == '(' && closingBracket != ')')
                {
                    Console.WriteLine("NO");
                    return "NO";
                }
                else if (openingBracket == '{' && closingBracket != '}')
                {
                    Console.WriteLine("NO");
                    return "NO";
                }
            }
        }

        Console.WriteLine("YES");
        return "YES";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("TESTE", true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
