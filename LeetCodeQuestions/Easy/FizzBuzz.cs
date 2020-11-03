/* Write a program that outputs the string representation of numbers from 1 to n. 
 * But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. 
 * For numbers which are multiples of both three and five output “FizzBuzz”. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestions.Easy
{
    class FizzBuzz
    {
        public IList<string> FizzBuzz1(int n)
        {
            List<string> buzz = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                StringBuilder sb = new StringBuilder();
                bool divisibleBy3 = ((i % 3) == 0);
                bool divisibleBy5 = ((i % 5) == 0);


                if (divisibleBy3)
                {
                    sb.Append("Fizz");
                }
                if (divisibleBy5)
                {
                    sb.Append("Buzz");
                }

                if (sb.Length == 0)
                {
                    sb.Append(i.ToString());
                }
                buzz.Add(sb.ToString());
            }
            return buzz;
        }
    }
}
