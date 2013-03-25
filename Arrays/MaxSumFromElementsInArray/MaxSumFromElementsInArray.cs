/* Write a program that reads two integer numbers
 * N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
 */

namespace MaxSumFromElementsInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaxSumFromElementsInArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for integer number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for integer number k: ");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
       
            string bestSeq = " ";
            int sum = 0;
            int bestSum = int.MinValue;
            int arrLength = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                string currenttSeq = " ";

                if (i + k > array.Length)
                {
                    break;
                }
            
                for (int j = i; j < i + k; j++)
                {
                    sum = sum + array[j];
                    currenttSeq = currenttSeq + ' ' + array[j];
                }

                if (sum > bestSum)
                {
                    bestSeq = currenttSeq;
                    bestSum = sum;
                }

                sum = 0;
            }

            Console.WriteLine(bestSeq);
            Console.WriteLine(bestSum);
        }
    }
}
