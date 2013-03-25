/*Write a program that finds the index of 
 * given element in a sorted array of 
 * integers by using the binary search 
 * algorithm (find it in Wikipedia).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int BinSearch(int[] array, int key)
        {
            Array.Sort(array);
            int iMax = array.Length - 1;
            int iMin = 0;
            while (iMax >= iMin)
            {
                int iMidpoint = (iMin + iMax) / 2;
                if (array[iMidpoint] < key)
                {
                    iMin = iMidpoint + 1;
                }
                else if (array[iMidpoint] > key)
                {
                    iMax = iMidpoint - 1;
                }
                else
                {
                    return iMidpoint;
                }
            }
            return -1;
        }
        static void Main()
        {
            int[] myArray = { 2, 5, 5, 1, 2, 3, 5, 1, 2, 56124, 21, 312, };
            int key = 3;
            Console.WriteLine(BinSearch(myArray, key));
        }
    }
}
