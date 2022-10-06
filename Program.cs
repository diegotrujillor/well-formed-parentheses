using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

// Given n pair of parenthesis, write a function to generate all combinations of well-formed parentheses.
// Constraints:
// 1 <= n < 8
// Example 1:
// Input: n = 1
// Output: ["()"]
// Example 2:
// Input: n = 3
// Output: ["((()))", "(()())", "(())()", "()(())", "()()()"]
// Input: n = 2
// Output: ["(())", "()()"]
namespace well_formed_parentheses
{
    class Program
    {
        static IList<string> GenerateParentheses(int n)
        {
            string parenthesesL = "(";
            string parenthesesR = ")";
            var builder = new StringBuilder();
            IList<string> output = new List<string>();

            if (n >= 1 && n < 8)
            {
                for (int i = 0; i < n; i++)
                {
                    builder.Append (parenthesesL);
                    builder.Append (parenthesesR);
                }
            }

            output.Add(builder.ToString());
            return output;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a numeric argument.");
            }
            else
            {
                var items = GenerateParentheses(Convert.ToInt32(args[0]));

                foreach (var item in items)
                {
                    Console.WriteLine (item);
                }
            }
        }
    }
}
