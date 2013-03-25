/* Write a program that finds in given array of
 * integers a sequence of given sum S (if present).
 * Example:      {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5} 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqOfGivenSum
{
    class SeqOfGivenSum
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int[] array = { 2, 3, 4, 1, 2, 3, 2, 3, 2, 3, 3, 5, 5 };
            string sequence = " ";
            StringBuilder seqBuild = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    seqBuild.AppendFormat("{0}, ", array[j]);

                    if (sum > s)
                    {
                        seqBuild.Clear();
                        sum = 0;
                        break;
                    }

                    if (sum == s)
                    {
                        sequence = seqBuild.ToString();
                        Console.WriteLine("This sequence has the sum of {0} : {1}", s, sequence);
                    }
                }
            }

        }
    }
}
