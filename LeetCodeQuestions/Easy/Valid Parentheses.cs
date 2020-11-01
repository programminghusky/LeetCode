/* Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0)
                return true;
            Stack<char> charStack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    charStack.Push(s[i]);
                }

                else if ((charStack.Count != 0) && ((s[i] == ')' && charStack.Peek() == '(') ||
                    (s[i] == ']' && charStack.Peek() == '[') ||
                    (s[i] == '}' && charStack.Peek() == '{')))
                {
                    charStack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return (charStack.Count == 0);
        }
    }
}
