/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
*/

namespace SeqOfMaxSumInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SeqOfMaxSumInArray
    {
        public static void Main(string[] args)
        {
            int[] array = { 23, 4, -4, -65, 3 };
            int sum = 0;
            int bestSum = int.MinValue;
            StringBuilder bestSeqBuild = new StringBuilder();
            string bestSeq = " ";

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                bestSeqBuild.AppendFormat("{0}, ", array[i]);

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestSeq = bestSeqBuild.ToString();
                }

                if (sum < 0)
                {
                    sum = 0;
                    bestSeqBuild.Clear();
                }
            }

            Console.WriteLine("The best sequence is: {0}", bestSeq);
            Console.WriteLine("The best sum is: {0}", bestSum);

        }
    }
}
