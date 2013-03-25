/*
 * Write a program that reads two arrays from
 * the console and compares them element by element.
 */

namespace ComparesTwoArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ComparesTwoArrays
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Enter element - {0} from the first array", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine("Enter element - {0} from the second array", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool areEqual = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }

            Console.WriteLine("The arrays are equal -- {0}", areEqual);
        }
    }
}
