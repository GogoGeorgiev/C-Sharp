/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/

namespace TheMostFrequentNumInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TheMostFrequentNumInArray
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9 };
            Dictionary<int, int> mostFrequent = new Dictionary<int, int>();
            int bestElement = 0;
            int bestFrequency = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int tempValue;

                if (mostFrequent.TryGetValue(array[i], out tempValue))
                {
                    mostFrequent[array[i]] = tempValue + 1;
                }
                else
                {
                    mostFrequent.Add(array[i], 1);
                }
            }

            foreach (var item in mostFrequent)
            {
                if (item.Value > bestFrequency)
                {
                    bestElement = item.Key;
                    bestFrequency = item.Value;
                }
            }

            Console.WriteLine("The number {0} shows {1} times", bestElement, bestFrequency);
        }
    }
}
