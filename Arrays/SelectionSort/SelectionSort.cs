/* Sorting an array means to arrange its elements
 * in increasing order. Write a program to sort 
 * an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position,
 * find the smallest from the rest, move it at the second position, etc.
 */

namespace SelectionSort
{
    using System;
   
   public class SelectionSort
    {
       public static void Main(string[] args)
        {
            int[] array = { 23, 4, 3, 543, 5, 5467, 5, 76, 5, 34, 32, 43, 243, 24, 234 };
           
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minElement = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minElement])
                    {
                        minElement = j;
                    }
                }

                if (minElement != i)
                {
                    int temp = 0;
                    temp = array[i];
                    array[i] = array[minElement];
                    array[minElement] = temp;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);
            }

            Console.WriteLine();
        }
    }
}
