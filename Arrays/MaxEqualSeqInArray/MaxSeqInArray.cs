/*Write a program that finds the maximal 
 * sequence of equal elements in an array.
    Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/
namespace MaxEqualSeqInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaxSeqInArray
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 1, 1, 2, 3, 3, 4, 4, 5 };
            List<int> maxSeqArray = new List<int>();
            int start = 0;
            int len = 1;
            int bestLen = 1;
            int bestStart = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
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

            Console.WriteLine("The maximal sequence of equal elements is: ");
            Console.Write("{ ");
            for (int k = bestStart; k < bestStart + bestLen; k++)
            {
                maxSeqArray.Add(array[k]);
                Console.Write(array[k] + ",");
            }

            Console.WriteLine("}"); 
        }
    }
}
