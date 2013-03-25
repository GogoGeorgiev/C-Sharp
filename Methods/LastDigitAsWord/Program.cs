/*Write a method that returns the last digit 
 * of given integer as an English word. 
 * Examples: 512  "two", 1024  "four", 12309  "nine".
 */

using System;

namespace LastDigitAsWord
{
    class Program
    {
        static int GetLastNumber( int lastNumber)
        {
            return lastNumber % 10;
        }


        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] digitNumbers = { "zero", "one", "two", "three", "four", "five",
                                        "six", "seven", "eight", "nine" };

            Console.WriteLine(digitNumbers[GetLastNumber(number)]); 

        }
    }
}
