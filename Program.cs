using System;
using System.Collections;
using System.Collections.Generic;

// Given n pair of parenthesis, write a function to generate all combinations of well-formed parentheses.
// Constraints:
// 1 <= n < 8
// Example 1:
// Input: n = 1
// Output: ["()"]
// Example 2:
// Input: n = 3
// Output: ["((()))", "(()())", "(())()", "()(())", "()()()"]
namespace well_formed_parentheses
{
    class Program
    {
        static IList<string> GenerateParenthesis(int n) 
        {
            IList<string> output = new List<string>();

            if (n >= 1 && n < 8)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(i);
                }    
            }

            return output;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a numeric argument.");
            }else
            {
                GenerateParenthesis(Convert.ToInt32(args[0]));
            }
        }
    }
}
