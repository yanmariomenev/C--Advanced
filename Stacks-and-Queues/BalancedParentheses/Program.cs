
using System.ComponentModel.Design;

namespace BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var matchParentheses = new Stack<char>();
            var input = Console.ReadLine().ToCharArray();
            var openParentheses = new char[] {'(', '{', '['};
            bool isValid = true;

            foreach (var item in input)
            {
                if (openParentheses.Contains(item))
                {
                    matchParentheses.Push(item);
                    continue;
                }

                if (matchParentheses.Count == 0)
                {
                    isValid = false;
                    break;
                }
                if (matchParentheses.Peek() == '(' && item == ')')
                {
                    matchParentheses.Pop();
                }
                else if (matchParentheses.Peek() == '[' && item == ']')
                {
                    matchParentheses.Pop();
                }
                else if (matchParentheses.Peek() == '{' && item == '}')
                {
                    matchParentheses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
                
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
