/* Write a program that finds the maximal
 * increasing sequence in an array. Example: 
 * {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

namespace MaxIncreasingSeqInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class MaxIncreasingSeqInArray
    {
        public static void Main(string[] args)
        {
            int[] array = { 2, 2, 2, 1, 2, 3, 5, 6, 7, 8, 9, 10, 2, 1, 2, 3, 4, 4 };
            List<int> incArrSeq = new List<int>();
            int len = 1;
            int bestLen = 1;
            int start = 0;
            int bestStart = 0;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    len = 1;
                    start = i + 1;
                }
            }

            Console.WriteLine("The maximal sequence of increasing elements is: ");
            Console.Write("{ ");
            for (int j = bestStart; j < bestStart + bestLen; j++)
            {
                incArrSeq.Add(array[j]);
                Console.Write(array[j] + ",");
            }

            Console.WriteLine("}"); 
        }
    }
}
