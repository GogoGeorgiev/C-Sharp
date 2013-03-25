/*
 * Write a program that compares two char 
 * arrays lexicographically (letter by letter).
*/

namespace ComparesTwoCharArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ComparesTwoCharArrays
    {
        public static void Main(string[] args)
        {
            char[] array1 = { 'q', 'w', 'e', 'r', 't', 'q' };
            char[] array2 = { 'q', 'w', 'e', 'r', 't', 'q' };
            bool areEqual = true;

            //// Checking the length of the arrays

            if (array1.Length != array2.Length)
            {
                areEqual = false;
                Console.WriteLine("Are the arrays lexicographically equal? -- {0}", areEqual);
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        areEqual = false;
                    }
                }

                Console.WriteLine("Are the arrays lexicographically equal? -- {0}", areEqual);
            }
        }
    }
}
