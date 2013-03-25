/* Write a method that returns the index
 * of the first element in array that is
 * bigger than its neighbors, or -1, if
 * there’s no such element.
 */

using System;

class BiggerThenNeighbors
{
    static int BiggerNeighborFinder(int[] array)
    {
        int index = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }
        return index;

    }
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 6, 3, 3, 3, 3 };
        Console.WriteLine(BiggerNeighborFinder(myArray));
    }
}